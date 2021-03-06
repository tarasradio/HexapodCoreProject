﻿using System;
using System.Collections.Generic;

namespace FrundGeneratorProject.Core
{
    public class FrundMoveFile
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public int Duration { get; private set; }
        public int CountRows { get; private set; }


        public List<MoveFrame> Frames { get; private set; }

        public FrundMoveFile(string path)
        {
            Frames = new List<MoveFrame>();
            OpenFile(path);
            Name = System.IO.Path.GetFileNameWithoutExtension(path);
            Title = "Файл движений";
        }

        private bool OpenFile(string fileName)
        {
            string[] lines = null;
            lines = System.IO.File.ReadAllLines(fileName);

            try
            {

                if (lines.Length == 0)
                    return false;

                Frames.Clear();
                CountRows = 0;

                MoveFrame currentFrame = new MoveFrame();
                int lastTime = 0;
                bool isFirst = true;

                foreach (string line in lines)
                {
                    int pos = 0; string temp = "";

                    pos = StringOperation.SkipWhiteSpaces(line, pos);
                    pos = StringOperation.ReadValue(line, ref temp, pos);
                    int number = int.Parse(temp);

                    pos = StringOperation.SkipWhiteSpaces(line, pos);
                    pos = StringOperation.ReadValue(line, ref temp, pos);
                    int time = int.Parse(temp.Replace(".", ""));

                    pos = StringOperation.SkipWhiteSpaces(line, pos);
                    pos = StringOperation.ReadValue(line, ref temp, pos);
                    double angle = double.Parse(temp.Replace('.', ','));
                    
                    angle = (180.0 / Math.PI) * angle;

                    angle *= -1;
                    angle += 90;
                    
                    if(isFirst)
                    {
                        lastTime = time;
                        isFirst = false;
                    }
					
                    if(time > lastTime)
                    {
                        currentFrame.Time = lastTime;
                        Frames.Add(currentFrame);
                        currentFrame = new MoveFrame();
                    }

                    currentFrame.AddMove(number, (int)angle);
                    lastTime = time;

                    CountRows++;
                    Duration = time;
                }
				
                currentFrame.Time = lastTime;
                Frames.Add(currentFrame);

                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}

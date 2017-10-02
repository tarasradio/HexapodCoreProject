using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    public class FrundMoveFile
    {
        public string _path; // путь к файлу
        public string Name; // название файла (из пути)
        public string Title; // Псевдоним файла

        public List<Move> Moves { get; set; }
        public ulong Duration { get; set; }
        public int CountRows { get; set; }

        public FrundMoveFile(string path)
        {
            _path = path;
            Moves = new List<Move>();
            openFile(path);
            Name = System.IO.Path.GetFileNameWithoutExtension(path);
            Title = "Файл движений";
        }

        public bool openFile(string fileName)
        {
            string[] lines = null;
            lines = System.IO.File.ReadAllLines(fileName);

            try
            {
                if (lines != null)
                {
                    Moves.Clear();
                    CountRows = 0;
                    Move nextMove;

                    foreach (string line in lines)
                    {
                        int pos = 0; string temp = "";

                        pos = StringOperation.SkipWhiteSpaces(line, pos);
                        pos = StringOperation.ReadValue(line, ref temp, pos);
                        int Number = int.Parse(temp);

                        pos = StringOperation.SkipWhiteSpaces(line, pos);
                        pos = StringOperation.ReadValue(line, ref temp, pos);
                        ulong Time = ulong.Parse(temp.Replace(".", ""));

                        pos = StringOperation.SkipWhiteSpaces(line, pos);
                        pos = StringOperation.ReadValue(line, ref temp, pos);
                        double Angle = double.Parse(temp.Replace('.', ','));

                        //Переводим угол в градусы
                        Angle = (180.0 / Math.PI) * Angle;
                        
                        nextMove = new Move(Time, Number, (int)Angle);
                        Moves.Add((Move)nextMove.Clone());

                        CountRows++;
                        Duration = Time;
                    }
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

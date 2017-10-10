using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    public class FrundMoveFile
    {
        public string Name { get; private set; }     // название файла (из пути)
        public string Title { get; private set; }    // Псевдоним файл
        public ulong Duration { get; private set; }
        public int CountRows { get; private set; }


        public List<Move> Moves { get; private set; }

        public FrundMoveFile(string path)
        {
            Moves = new List<Move>();
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

                    Angle *= -1;
                    Angle += 90;

                    nextMove = new Move(Time, Number, (int)Angle);
                    Moves.Add((Move)nextMove.Clone());

                    CountRows++;
                    Duration = Time;
                }
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}

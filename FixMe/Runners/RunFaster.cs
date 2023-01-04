using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using FixMe.Entities;
using FixMe.Options;

namespace FixMe.Runners
{
    public class RunFaster
    {
        private readonly RunnerOptions options;

        private object[] _all_the_cheats;

        public RunFaster()
        {
            options = new RunnerOptions();
            _all_the_cheats = Fill.FillDataObjectArray();
        }
        
        [Benchmark]
        public void Run() 
        {
            using (StreamWriter sw1 = File.AppendText(options.CuirckleFilePath))
            using (StreamWriter sw2 = File.AppendText(options.AtrangleFilePath))
            {
                {
                    for (int i = 0; i < _all_the_cheats.Count(); i++)
                    {
                        var cheatType = _all_the_cheats[i];
                        if (cheatType is Cuirckle)
                        {

                            {
                                var _irckle = cheatType as Cuirckle;
                                double circumference = _irckle.Calculate;
                                sw1.WriteLine($"Circumference of circle: {_irckle.RandomRadius}:{circumference}");
                            }

                        }
                        else
                        {

                            {
                                var _angle = cheatType as Atrangle;
                                double area = _angle.Calculate;
                                sw2.WriteLine($"Area of triangle: {area}");
                            }
                        }
                    }
                    sw1.Flush();
                    sw2.Flush();
                }
            }
        }
    }
}

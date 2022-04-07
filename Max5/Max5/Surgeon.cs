using System;
using System.Collections.Generic;
using System.Text;

namespace Max5
{
    class Surgeon : IDoctor
    {
        string university;

        public Surgeon(string university)
        {
            this.university = university;
        }

        public string WorkState { get; set; }

        public void StopWork()
        {
            WorkState = "Отдыхает";
        }

        public void Work()
        {
            WorkState = "Работает";
        }
    }
}

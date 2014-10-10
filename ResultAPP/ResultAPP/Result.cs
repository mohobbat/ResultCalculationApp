using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ResultAPP
{
    class Result
    {
        private readonly float _physics;
        private float physics;

        public float Physics
        {
            get { return physics; }
            set { physics = value; }
        }

        private float chemistry;
        public float Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }
        private float mathmetics;
        public float Mathmetics
        {
            get { return mathmetics; }
            set { mathmetics = value; }
        }
        private float getresult;
        public float Getresult
        {
            get { return getresult; }
            set { getresult = value; }
        }
        private string grade;
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }




        public Result(float physics, float chemistry, float mathmetics)
        {
            Physics = physics;
            
            Chemistry = chemistry;
            Mathmetics = mathmetics;
        }

        public float GetAvrageRe()
        {

            getresult = (physics + chemistry + mathmetics)/3;

            GetGrade();
            return getresult;
        }


        public void GetGrade()
        {
            if (getresult >= 80)
            {
                Grade = "A+";
            }
            else if(getresult<80 && getresult>=70)
            {
                Grade = "B+";

            }
            else if (getresult < 70 && getresult >= 60)
            {
                Grade = "C+";
            }
            else if (getresult < 60 && getresult >= 50)
            {
                Grade = "D+";
            }
            else if (getresult < 50 && getresult >= 40)
            {
                Grade = "F";
            }

        }




    }
}

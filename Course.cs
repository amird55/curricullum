using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idan_and_Yaheli
{
    internal class Course
    {
        private int cID;
        private string cName;
        private int mDuration;
        private int mPerWeek;
        private Teacher cTeacher;
        private List<Pupil> pupils;

        public Course (int cID, string cName, int mDuration, int mPerWeek, Teacher cTeacher, List<Pupil> pupils)
        {
            this.cID = cID;
            this.cName = cName;
            this.mDuration = mDuration;
            this.mPerWeek = mPerWeek;
            this.cTeacher = cTeacher;
            this.pupils = pupils;
        }

        public int GetcID () { return cID; }
        public string GetcName () { return cName; }
        public int GetmDuration () { return mDuration; }
        public int GetmPerWeek () { return mPerWeek; }
        public Teacher GetTeacher () { return cTeacher; }
        public List<Pupil> GetPupils () { return pupils; }

        public int SetcID (int cID) { this.cID = cID; return this.cID; }
        public void SetcName (string cName) { this.cName = cName; }
        public void SetmDuration (int mDuration) { this.mDuration = mDuration; }
        public void SetmPerWeek (int mPerWeek) { this.mPerWeek = mPerWeek; }
        public void SetTeahcer (Teacher cTeacher) { this.cTeacher = cTeacher; }
        public void SetPupils (List<Pupil> pupils) { this.pupils = pupils; }        
    }
}

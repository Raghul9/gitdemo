using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Exam
    {
        public int id { get; set; } 

        public string examname { get; set; }


        internal Exam(int id, string examname)
        {
            this.id = id;
            this.examname = examname;
        }

        internal void ExamInfo()
        {
            Console.WriteLine("id :{0},examname: {1}", id, examname);



        }
        ~Exam()
        {
            Console.WriteLine("ExamResult destructor");
        }




    }//derived class or child class
    class Student : Exam
    {
        public int sid { get; set; }

        public string sname { get; set; }


        public string contactno { get; set; }

        public string status { get; set; }


        internal Student(int id, string examname, int sid, string sname, string contactno, string status):base(id,examname)
        {
            this.sid = sid;
            this.sname = sname;
            this.contactno = contactno;
            this.status = status;
        }
        internal void PrintData()
        {
            Console.WriteLine("examid:{0},examname:{1}", id, examname);
        }
        internal void ExamStatus()
        {
            Console.WriteLine("studentid:{0},ename: {1},contactno:{2},status:{3}", base.id, sname, contactno, status);
        }

        ~Student()
        {
            Console.WriteLine("ExamResult destructor");
        }


    }

    class ExamResult : Student
    {
        public int score { get; set; }

        internal ExamResult(int id, string examname, int sid, string sname, string contactno,string status, int score ) : base(id, examname, sid, sname, contactno,status)
        {
            Console.WriteLine("ExamResult Constructor");
            this.score = score;
        }


        internal void Result()
        {
            ExamStatus();
            Console.WriteLine("Ename:{0}, || sid:{1},score:{2}", examname, id, score);
        }

        ~ExamResult()
        {
            Console.WriteLine("ExamResult destructor");
        }


    }
    class GovtExam
    {
        static void Main()
        {
            /* Student student = new Student(1000, "TRB", 101, "Hari", "9876543212", "Attended");
             student.ExamInfo();

             student.PrintData();*/
            //student.ExamStatus();

            ExamResult examResult =new ExamResult(1000, "TRB", 101, "Hari", "9876543212","Attended",190);
            examResult.ExamInfo();
            examResult.Result();

          

        }


    }




}

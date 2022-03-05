﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_Emplib
{
    public class Emp
    {
        private int empno;
        private string ename;
        private int sal;

        public Emp() { }//생성자 함수 >> 속성의 초기화
        public Emp(int empno, string ename, int sal) //생성자 함수(오버로딩)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
        }
        //속성
        // private int empno; 캡슐화된 자원에 대해서 read, write 기능 제공
        public int Empno //private int empno 자원에 간접적으로 get, set 사용가능
        {
            get { return empno; }
            set { empno = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }
        public int Sal 
        {
            get { return sal; }
            set { sal = value; }
        }

        public void EmpPring()
        {
            Console.WriteLine("{0} - {1} - {2}", this.empno, this.ename, this.sal);
        }
    }
}
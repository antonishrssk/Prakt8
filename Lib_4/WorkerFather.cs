using System;

namespace Lib_4
{
    public class WorkerFather : IComparable, ICloneable, IWorker, IFather
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public int Children { get; set; }

        public WorkerFather(string firstName, string lastName, string job, int children)
        {
            FirstName = firstName;
            LastName = lastName;
            Job = job;
            Children = children;
        }

        /// <summary>
        /// ��������� ������� ���� ����������
        /// </summary>
        /// <param name="obj">������� ������ �� ����������</param>
        /// <returns>0, ���� ������� ���������; 1 ��� -1, ���� ������� �����������</returns>
        public int CompareTo(object obj)
        {
            WorkerFather temp = (WorkerFather)obj;
            return String.Compare(this.LastName, temp.LastName);
        }
        
        /// <summary>
        /// ������������ ���������
        /// </summary>
        /// <returns>�������� � ���� �� ��������, ������, ���������� � ������ ����� � �����</returns>
        public object Clone()
        {
            return new WorkerFather(this.FirstName, this.LastName, this.Job, this.Children);
        }
        
        /// <summary>
        /// ����� ���������� � ���������
        /// </summary>
        /// <param name="n">��������</param>
        /// <returns>���������� � ���������</returns>
        public static string GetInfo(WorkerFather n)
        {
            return $"{n.FirstName} {n.LastName}, ��������� - {n.Job}, ����� � ����� - {n.Children}";
        }
    }
}

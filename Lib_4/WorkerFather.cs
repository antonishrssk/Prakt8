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
        /// Сравнение фамилий двух работников
        /// </summary>
        /// <param name="obj">Фамилия одного из работников</param>
        /// <returns>0, если фамилии одинаковы; 1 или -1, если фамилии различаются</returns>
        public int CompareTo(object obj)
        {
            WorkerFather temp = (WorkerFather)obj;
            return String.Compare(this.LastName, temp.LastName);
        }
        
        /// <summary>
        /// Клонирование работника
        /// </summary>
        /// <returns>Работник с теми же фамилией, именем, профессией и числом детей в семье</returns>
        public object Clone()
        {
            return new WorkerFather(this.FirstName, this.LastName, this.Job, this.Children);
        }
        
        /// <summary>
        /// Вывод информации о работнике
        /// </summary>
        /// <param name="n">Работник</param>
        /// <returns>Информация о работнике</returns>
        public static string GetInfo(WorkerFather n)
        {
            return $"{n.FirstName} {n.LastName}, профессия - {n.Job}, детей в семье - {n.Children}";
        }
    }
}

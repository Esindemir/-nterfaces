using System;

namespace İnterfaces
{
    {
        //İnterface newlenemez 
        private static void Main(string[] args)
    class Program
        {
            //IPersonManager customerManager = new CustumerManager();

            //IPersonManager employeeManager = new EmployeeManager();
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustumerManager()); 

        }
    }

    interface IPersonManager 
    {
        //unimplemented operation - tamamlanmamış operasyon
        void Add();
        void Update();


    }
    //inherits - class ......... İmplements - İnterface

    class CustumerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        //Personel ekleme kodları
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add( IPersonManager personManager)
        {
            
            personManager.Add();

        }
        
    }
}

using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Person
{
     public string PersonID { get; set;}
     public string FullName { get; set; }
     public int Age{get; set; }
     public void SetData()
     {
          PersonID = "0987654321";
          FullName = "Nguyen Van A";
          Age = 19;
     }
     // public int GetyearOfBirth(int Age) {
     //       int yearOfBirth =2023 - Age;
     //       return yearOfBirth;
     //       }
     // public void Data(){
     //      System.Console.Write("PersionID = ");
     //      PersonID = Console.ReadLine();
     //      System.Console.Write("full name = ");
     //      FullName = Console.ReadLine();
     //      System.Console.Write("Age = ");
     //      Age = Convert.ToInt16(Console.ReadLine());
     // }
     // public void EnterData(){
          
     //      // ke thua lai phuong thuc o class person
     //      base.EnterData();
     //      //phat tien them thong tin studentcode
     //      System.Console.Write("Studentcode = ");
     //      Studentcode = Console.ReadLine();
     // }
     // public void Display(){
     //      System.Console.Write("{0} - {1} - ", PersonID, FullName, Age);
     // } 
     // public void Display(string ten, int tuoi){
     //      System.Console.Write("Sinh vien {0} - {1} tuoi ", ten, tuoi );
     // }
     // public void Display(){
     //      base.Display();
     //      System.Console.Write("Ma sinh vien: {0} ", Studentcode);
     // }
}
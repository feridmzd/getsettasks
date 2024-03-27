namespace Consoleclasstask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ferid","Memmedzade",20);
            Student student=new Student("Ferid","Memmedzade",20,10320,95);
            //student.Showfullinfo();
            Human human=new Human("Elsad","Ibrahimov","Kisi",27);
            Doctor doctor = new Doctor("Elsad", "Ibrahimov", "Kisi", 27, "Cerrah",3);
            //human.ShowInfo();

        }
    }
}

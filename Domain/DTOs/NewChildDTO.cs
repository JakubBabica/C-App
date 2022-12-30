namespace Domain.DTOs;

public class NewChildDTO
{
    public int id { get; }
    public string Name { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
    //public List<Toy> toys { get; set; }
    public NewChildDTO(int id,string name,int age,string gender)
    {
        this.id = id;
        this.Name = name;
        this.age = age;
        this.gender = gender;
        //this.toys = toys;
    }
}
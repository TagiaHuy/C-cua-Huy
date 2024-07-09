
public abstract class Person
{
    public string Name { get; set; }
    public string Id { get; set; }

    public Person(string name, string id) {
        Name = name;
        Id = id;
    }
}
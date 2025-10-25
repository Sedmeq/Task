using Inheritance_2;

Animal[] animals =
{
    new Dog("it1", 3, "havhav", "Pitbul"),
    new Dog("it2", 4, "hav", "corgi"),
    new Cat("pisik1", 2, "Meow","ag"),
    new Cat("pisik2", 1, "meomeo", "ag-qara"),
    new Bird("quw1", 5, "cikcik", 20),
    new Bird("quw2", 1, "cik", 15)
};
foreach (var animal in animals)
{
    animal.GetInfo();
}

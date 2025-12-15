Clothes[] arr = new Clothes[4];
Console.WriteLine("Введите размер футболки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цену футболки");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цвет футболки");
string c = Console.ReadLine();
T_Shirt t_Shirt = new T_Shirt(a, b, c);
arr[0] = t_Shirt;
Console.WriteLine("Введите размер штанов");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цену штанов");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цвет штанов");
string c1 = Console.ReadLine();
Pants pants = new Pants(a1, b1, c1);
arr[1] = pants;
Console.WriteLine("Введите размер юбки");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цену юбки");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цвет юбки");
string c2 = Console.ReadLine();
Skirt skirt = new Skirt(a1, b1, c1);
arr[2] = skirt;
Console.WriteLine("Введите размер штанов");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цену штанов");
int b3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цвет штанов");
string c3 = Console.ReadLine();
Galstuk galstuk = new Galstuk(a3, b3, c3);
arr[3] = galstuk;
Atele ate = new Atele(arr);
ate.WearMen();
ate.WearWomen();
interface ManClothes
{
    bool wearMan()
    {
        return false;
    }
}
interface WomanClothes
{
    bool wearWoman()
    {
        return false;
    }
}
abstract class Clothes:ManClothes, WomanClothes
{
    public int rasmer = 42;
    public int cost = 3000;
    public string color = "black";
    public string name = "";
    public Clothes(int rasmeR, int cosT, string coloR)
    {
        rasmer = rasmeR;
        cost = cosT;
        color = coloR;
    }
    public virtual bool wearMan()
    {
        return false;
    }
    public virtual bool wearWoman()
    {
        return false;
    }
}
class T_Shirt : Clothes
{
    //public string name = "Футболка";
    public T_Shirt(int rasmeR, int cosT, string coloR) : base(rasmeR, cosT, coloR)
    {
        rasmer = rasmeR;
        cost = cosT;
        color = coloR;
    }
    public override bool wearWoman()
    {
        name = "Футболка";
        return true;
    }
    public override bool wearMan()
    {
        name = "Футболка";
        return true;
    }
}
class Pants : Clothes
{
    //public string name = "Штаны";
    public Pants(int rasmeR, int cosT, string coloR) : base(rasmeR, cosT, coloR)
    {
        rasmer = rasmeR;
        cost = cosT;
        color = coloR;
    }
    public override bool wearWoman()
    {
        name = "Штаны";
        return true;
    }
    public override bool wearMan()
    {
        name = "Штаны";
        return true;
    }
}
class Skirt : Clothes
{
    //public string name = "Юбка";
    public Skirt(int rasmeR, int cosT, string coloR) : base(rasmeR, cosT, coloR)
    {
        rasmer = rasmeR;
        cost = cosT;
        color = coloR;
    }
    public override bool wearWoman()
    {
        name = "Юбка";
        return true;
    }
}
class Galstuk : Clothes
{
    //public string name = "Галстук";
    public Galstuk(int rasmeR, int cosT, string coloR) : base(rasmeR, cosT, coloR)
    {
        rasmer = rasmeR;
        cost = cosT;
        color = coloR;
    }
    public override bool wearMan()
    {
        name = "Галстук";
        return true;
    }
}
class Atele
{
    public Clothes[] arr;
    public Atele(Clothes[] arrr)
    {
        arr = arrr;
    }
    public void WearMen()
    {
        Console.WriteLine("Мужская одежда:");
        foreach (Clothes c in arr) {
            if (c.wearMan())
            {
                Console.WriteLine(c.name);
            }
        }
    }
    public void WearWomen()
    {
        Console.WriteLine("Женская одежда:");
        foreach (Clothes c in arr)
        {
            if (c.wearWoman())
            {
                Console.WriteLine(c.name);
            }
        }
    }
}

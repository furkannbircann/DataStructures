using System.Threading;
using System.Collections;
class Program
{

    public static void Main(string[] args)
    {

        
        // TreeExamp();
        // SortedSetExamp2();
        // SortedSetExamp();
        // SortedDictionaryExamp();
        // DictionaryExamp();
        // StackExamp();
        // ListExamp();
        // SortedListExamp();
        // HashTableExamp2();
        // HashTableExamp();
        // ArrayExamp();
    }

    private static void TreeExamp()
    {
        Tree bst = new Tree();
        bst.Root = bst.insert(bst.Root, 12);
        bst.Root = bst.insert(bst.Root, 7);
        bst.Root = bst.insert(bst.Root, 17);
        bst.Root = bst.insert(bst.Root, 22);
        bst.Root = bst.insert(bst.Root, 5);
        bst.Root = bst.insert(bst.Root, 14);
        bst.Root = bst.insert(bst.Root, 11);
        System.Console.WriteLine("PREORDER");
        bst.preOrder(bst.Root);
        System.Console.WriteLine();
        System.Console.WriteLine("INORDER");
        bst.inOrder(bst.Root);
        System.Console.WriteLine();
        System.Console.WriteLine("POSTORDER");
        bst.postOrder(bst.Root);

        // System.Console.WriteLine($"root : {bst.Root.Data}");
        // System.Console.WriteLine($"root.right : {bst.Root.Right.Data}");
        // System.Console.WriteLine($"root.left : {bst.Root.Left.Data}");
    }

    private static void SortedSetExamp2()
    {
        SortedSet<int> a = new SortedSet<int>() { 1, 5, 6, 7, 8 };
        SortedSet<int> b = new SortedSet<int>() { 1, 2, 3, 4, 5, };

        System.Console.WriteLine("A'nın elemanları");
        foreach (var item in a)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("B'nin elemanları");
        foreach (var item in b)
        {
            System.Console.WriteLine(item);
        }

        a.UnionWith(b);
        System.Console.WriteLine("A birleşim B");
        foreach (var item in a)
        {
            System.Console.WriteLine(item);
        }
    }

    private static void SortedSetExamp()
    {
        SortedSet<string> list = new SortedSet<string>();

        list.Add("Furkan");


        list.RemoveWhere(x => x.Contains('a'));

        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
    }

    private static void SortedDictionaryExamp()
    {
        SortedDictionary<string, List<int>> list = new SortedDictionary<string, List<int>>(){
            {"FTP",new List<int>(){3,5,7}},
            {"HTML",new List<int>(){8,10,12}}
        };
    }

    private static void DictionaryExamp()
    {
        Dictionary<int, string> cities = new Dictionary<int, string>()
        {
            {212,"İstanbul"},
            {352,"Kayseri"},
            {332,"Konya"}
        };

        cities[212] = "İstanbul!";
        Console.WriteLine(cities[212]);

        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }
    }

    private static void StackExamp()
    {
        Stack<char> charStack = new Stack<char>();
        for (int i = 65; i <= 90; i++)
        {
            charStack.Push(((char)i));
            Console.WriteLine($"{charStack.Peek()} yığına eklendi");
        }
    }

    private static void ListExamp()
    {
        List<int> numbers = new List<int>(){
            1,5,6,7,2,3,5,7,23,4,6,14,14,325,26,7,124,5,5,36,12
        };
        numbers.Sort();
        numbers.ForEach(num => Console.WriteLine(num));
        //     private class City : IComparable<City>
        // {
        //     public int PlateNo { get; set; }
        //     public string? CityName { get; set; }

        //     public int CompareTo(City? other)
        //     {
        //         if (this.PlateNo < other.PlateNo)
        //         {
        //             return -1;
        //         }
        //         else if (this.PlateNo == other.PlateNo)
        //         {
        //             return 0;
        //         }
        //         else
        //         {
        //             return 1;
        //         }
        //     }
        // }
    }

    private static void SortedListExamp()
    {
        SortedList sortedList = new SortedList(){
            {1,"Bir"},
            {4,"Dört"},
            {3,"Üç"},
            {2,"İki"},
        };

        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(sortedList[4]);
        Console.WriteLine(sortedList.GetByIndex(3));
        Console.WriteLine(sortedList.GetKey(3));

        var listKeys = sortedList.Keys;
        var listValues = sortedList.Values;
    }

    private static void HashTableExamp2()
    {
        System.Console.Write("Başlık bilgisi giriniz =  ");
        string? text = Console.ReadLine();
        string? lowerText = text?.ToLower();

        var charset = new Hashtable(){
            {'ç','c'},
            {'ı','i'},
            {'ö','o'},
            {'ü','u'},
            {' ','-'},
            {'\'','-'},
            {'ğ','g'},
            {'.','-'},
        };

        foreach (DictionaryEntry item in charset)
        {
            lowerText = lowerText?.Replace((char)item.Key, (char)item.Value);
        }
        Console.WriteLine(lowerText);
    }

    private static void HashTableExamp()
    {
        Hashtable cities = new Hashtable();
        cities.Add(6, "Ankara");
        cities.Add(38, "Kayseri");
        cities.Add(42, "Konya");

        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }

        var values = cities.Values;
        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
    }

    private static void ArrayExamp()
    {
        int[] numArray = new int[] { 51, 5, 6, 7, 23, 4, 6, 8, 234, 6, 7, 9, 3, 0, 12, 3, 5, 125, 6, 7 };
        var numbers = Array.CreateInstance(typeof(int), numArray.Length);
        var arr = new ArrayList(numArray);
        numArray.CopyTo(numbers, 0);
        Array.Sort(numArray);
        Array.Sort(numbers);
        arr.Sort();

        System.Console.WriteLine(Array.IndexOf(numbers, 23));


        for (int i = 0; i < numArray.Length; i++)
        {
            System.Console.WriteLine($"numArray[{i}] = {numArray[i],3} - numbers[{i}] = {numbers.GetValue(i),3} - arr[{i}] = {arr[i],3}");
        }
    }
}
class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }
    public Node(int Data)
    {
        this.Data = Data;
        this.Left = null;
        this.Right = null;
    }
}
class Tree
{
    public Node? Root { get; set; }
    public Tree()
    {
        this.Root = null;
    }
    public Node newNode(int data)
    {
        Root = new Node(data);
        return Root;
    }
    public Node insert(Node root, int data)
    {
        Node nodeItem = new Node(data);
        if (root != null)
        {
            if (data < root.Data)
            {
                root.Left = insert(root.Left, data);
            }
            else
            {
                root.Right = insert(root.Right, data);
            }
        }
        else
            root = newNode(data);
        return root;
    }
    public void preOrder(Node root)
    {
        if (root != null)
        {
            System.Console.Write(root.Data + "    ");
            preOrder(root.Left);
            preOrder(root.Right);

        }
    }
    public void inOrder(Node root)
    {
        if (root != null)
        {
            inOrder(root.Left);
            System.Console.Write(root.Data + "    ");
            inOrder(root.Right);
        }
    }
    public void postOrder(Node root)
    {
        if (root != null)
        {
            postOrder(root.Left);
            postOrder(root.Right);
            System.Console.Write(root.Data + "    ");
        }
    }

}


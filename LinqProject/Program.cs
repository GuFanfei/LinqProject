using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region As和Is的用法
            //AsIsDemo obj = new AsIsDemo();
            //obj.IsTest(1);
            #endregion

            #region 深度浅度拷贝
            //DeepAndShallow a = new DeepAndShallow();
            //a.i = 10;
            //a.iArr = new int[] { 8, 9, 10 };
            //DeepAndShallow b = a.Clone1();
            //DeepAndShallow c = a.Clone2();
            //DeepAndShallow d = a;
            //// 更改 a 对象的iArr[0], 导致 b 对象的iArr[0] 也发生了变化 而 c不会变化
            //a.iArr[0] = 88;
            //Console.WriteLine("MemberwiseClone");
            //Console.WriteLine(b.i);
            //foreach (var item in b.iArr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Clone2");
            //Console.WriteLine(c.i);
            //foreach (var item in c.iArr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Clone3");
            //Console.WriteLine(d.i);
            //foreach (var item in d.iArr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SortedSet用法
            ////添加一些不同年龄的人
            //SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortedSetDemo())
            //{
            //    new Person() {FirstName = "Homer", LastName = "Simpson", Age = 47},
            //    new Person() {FirstName = "Marge", LastName = "Simpson", Age = 45},
            //    new Person() {FirstName = "Lisa", LastName = "Simpson", Age = 9},
            //    new Person() {FirstName = "Bart", LastName = "Simpson", Age = 8}
            //};

            ////各项是按照年龄排序的
            //foreach (Person p in setOfPeople)
            //{
            //    Console.WriteLine(p.FirstName+" "+p.Age);
            //}
            //Console.WriteLine();

            ////添加一些人
            //setOfPeople.Add(new Person() {FirstName = "Saku",LastName = "Jones",Age=1});
            //setOfPeople.Add(new Person() { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            //foreach (Person p in setOfPeople)
            //{
            //    Console.WriteLine(p.FirstName + " " + p.Age);
            //}
            //Console.WriteLine();
            #endregion

            #region ObservableCollection用法
            ////创建一个用来观察的集合，并添加一些Person对象
            //ObservableCollection<Person> people = new ObservableCollection<Person>()
            //{
            //    new Person() {FirstName = "Peter",LastName = "Murphy",Age=52},
            //    new Person() {FirstName = "Peter",LastName = "Murphy",Age=48}
            //};

            ////绑定CollectionChanged事件
            //people.CollectionChanged += ObservableCollectionDemo.people_CollectionChanged;

            //people.Add(new Person()
            //{
            //    FirstName = "Gu",
            //    LastName = "Fanfei",
            //    Age = 28
            //});

            ////people.Remove(new Person()
            ////{
            ////    FirstName = "Peter",
            ////    LastName = "Murphy",
            ////    Age = 52
            ////});
            //people.RemoveAt(0);
            #endregion

            //LinqDemo.QueryOverStrings();
            //LinqDemo.OfTypeAsFilter();
            //LinqDemo.LINQOverArrayList();
            //LinqDemo.GetCountFromQuery();
            //LinqDemo.AggregateOps();
            LinqDemo.QueryStringsWithAnonymousMethods();
            Console.ReadKey();
        }

    }
}

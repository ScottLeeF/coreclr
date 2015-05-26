// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;

public struct ValX0 { }
public struct ValY0 { }
public struct ValX1<T> { }
public struct ValY1<T> { }
public struct ValX2<T, U> { }
public struct ValY2<T, U> { }
public struct ValX3<T, U, V> { }
public struct ValY3<T, U, V> { }
public class RefX0 { }
public class RefY0 { }
public class RefX1<T> { }
public class RefY1<T> { }
public class RefX2<T, U> { }
public class RefY2<T, U> { }
public class RefX3<T, U, V> { }
public class RefY3<T, U, V> { }


public interface IGen<T>
{
    void _Init(T fld1);
    bool InstVerify(System.Type t1);
}


public interface IGenSubInt : IGen<int> { }
public interface IGenSubDouble : IGen<double> { }
public interface IGenSubString : IGen<string> { }
public interface IGenSubObject : IGen<object> { }
public interface IGenSubGuid : IGen<Guid> { }
public interface IGenSubConstructedReference : IGen<RefX1<int>> { }
public interface IGenSubConstructedValue : IGen<ValX1<string>> { }
public interface IGenSub1DIntArray : IGen<int[]> { }
public interface IGenSub2DStringArray : IGen<string[,]> { }
public interface IGenSubJaggedObjectArray : IGen<object[][]> { }


public struct GenInt : IGenSubInt
{
    int Fld1;

    public void _Init(int fld1)
    {
        Fld1 = fld1;
    }

    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<int>));
        }

        return result;
    }
}

public struct GenDouble : IGenSubDouble
{
    double Fld1;

    public void _Init(double fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<double>));
        }

        return result;
    }
}

public struct GenString : IGenSubString
{
    string Fld1;

    public void _Init(string fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<string>));
        }

        return result;
    }
}

public struct GenObject : IGenSubObject
{
    object Fld1;

    public void _Init(object fld1)
    {
        Fld1 = fld1;
    }

    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<object>));
        }

        return result;
    }
}

public struct GenGuid : IGenSubGuid
{
    Guid Fld1;

    public void _Init(Guid fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<Guid>));
        }

        return result;
    }
}

public struct GenConstructedReference : IGenSubConstructedReference
{
    RefX1<int> Fld1;

    public void _Init(RefX1<int> fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<RefX1<int>>));
        }

        return result;
    }
}

public struct GenConstructedValue : IGenSubConstructedValue
{
    ValX1<string> Fld1;

    public void _Init(ValX1<string> fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<ValX1<string>>));
        }

        return result;
    }
}


public struct Gen1DIntArray : IGenSub1DIntArray
{
    int[] Fld1;

    public void _Init(int[] fld1)
    {
        Fld1 = fld1;
    }

    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<int[]>));
        }

        return result;
    }
}

public struct Gen2DStringArray : IGenSub2DStringArray
{
    string[,] Fld1;

    public void _Init(string[,] fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<string[,]>));
        }

        return result;
    }
}

public struct GenJaggedObjectArray : IGenSubJaggedObjectArray
{
    object[][] Fld1;

    public void _Init(object[][] fld1)
    {
        Fld1 = fld1;
    }


    public bool InstVerify(System.Type t1)
    {
        bool result = true;

        if (!(Fld1.GetType().Equals(t1)))
        {
            result = false;
            Console.WriteLine("Failed to verify type of Fld1 in: " + typeof(IGen<object[][]>));
        }

        return result;
    }
}


public class Test
{
    public static int counter = 0;
    public static bool result = true;
    public static void Eval(bool exp)
    {
        counter++;
        if (!exp)
        {
            result = exp;
            Console.WriteLine("Test Failed at location: " + counter);
        }

    }

    public static int Main()
    {
        IGen<int> IGenInt = new GenInt();
        IGenInt._Init(new int());
        Eval(IGenInt.InstVerify(typeof(int)));

        IGen<double> IGenDouble = new GenDouble();
        IGenDouble._Init(new double());
        Eval(IGenDouble.InstVerify(typeof(double)));

        IGen<string> IGenString = new GenString();
        IGenString._Init("string");
        Eval(IGenString.InstVerify(typeof(string)));

        IGen<object> IGenObject = new GenObject();
        IGenObject._Init(new object());
        Eval(IGenObject.InstVerify(typeof(object)));

        IGen<Guid> IGenGuid = new GenGuid();
        IGenGuid._Init(new Guid());
        Eval(IGenGuid.InstVerify(typeof(Guid)));

        IGen<RefX1<int>> IGenConstructedReference = new GenConstructedReference();
        IGenConstructedReference._Init(new RefX1<int>());
        Eval(IGenConstructedReference.InstVerify(typeof(RefX1<int>)));

        IGen<ValX1<string>> IGenConstructedValue = new GenConstructedValue();
        IGenConstructedValue._Init(new ValX1<string>());
        Eval(IGenConstructedValue.InstVerify(typeof(ValX1<string>)));

        IGen<int[]> IGen1DIntArray = new Gen1DIntArray();
        IGen1DIntArray._Init(new int[1]);
        Eval(IGen1DIntArray.InstVerify(typeof(int[])));

        IGen<string[,]> IGen2DStringArray = new Gen2DStringArray();
        IGen2DStringArray._Init(new string[1, 1]);
        Eval(IGen2DStringArray.InstVerify(typeof(string[,])));

        IGen<object[][]> IGenJaggedObjectArray = new GenJaggedObjectArray();
        IGenJaggedObjectArray._Init(new object[1][]);
        Eval(IGenJaggedObjectArray.InstVerify(typeof(object[][])));

        if (result)
        {
            Console.WriteLine("Test Passed");
            return 100;
        }
        else
        {
            Console.WriteLine("Test Failed");
            return 1;
        }
    }

}

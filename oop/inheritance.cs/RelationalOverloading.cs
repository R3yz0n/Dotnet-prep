class RelationalOverloading
{
    internal int num;
    internal string? name;

    public static bool operator >(RelationalOverloading r1, RelationalOverloading r2)
    {
        return r1.num > r2.num;
    }

    public static bool operator <(RelationalOverloading r1, RelationalOverloading r2)
    {
        return r1.num < r2.num;
    }

}
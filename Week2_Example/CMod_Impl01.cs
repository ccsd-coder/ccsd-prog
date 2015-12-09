
namespace SM_Framework
{
    public partial class CMod
    {
        public static void Test()
        {
            CClass c1 = new CClass(".NET Programming I", 205, false);
            CClass c2 = new CClass("Database Programming I", 140, true);
            CClass c3 = new CClass("Objected Oriented Programming I", 204, true);

            CMod mod12 = new CMod("Mod 12");

            mod12.AddClass(c1);
            mod12.AddClass(c2);
            mod12.AddClass(c3);

            mod12.Debug();
            return;
        }
    }
}

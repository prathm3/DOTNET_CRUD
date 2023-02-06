namespace BusinessLogicLayer;
using BusinessObjectLayer;
using DaoLayer;
public class DataManager
{
    public static CollectionContext ctx = new CollectionContext();

    public List<Data> getAlldata()
    {
        return ctx.data.ToList();
    }
    public Data getData(string id)
    {
        int dataId = Convert.ToInt32(id);
        var data = ctx.data.Find(dataId);
        return data as Data;
    }
    public void add(Data obj)
    {
        ctx.data.Add(obj);
        ctx.SaveChanges();
    }
    public void delete(string id)
    {
        int dataId = Convert.ToInt32(id);
        var data = ctx.data.Find(dataId);
        ctx.data.Remove(data as Data);
        ctx.SaveChanges();
    }

    public void edit(Data obj)
    {
        int dataId = Convert.ToInt32(obj.id);
        var data = ctx.data.Find(dataId);
        Console.WriteLine(obj.id);
        if (data != null)
        {
            data.topic = obj.topic;
            data.loaction = obj.loaction;
            data.faculty = obj.faculty;
        }
        ctx.SaveChanges();
    }

}

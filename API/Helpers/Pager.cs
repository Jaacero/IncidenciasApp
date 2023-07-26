
namespace API.Helpers;

public class Pager<T> where T : class
{

    public string Search { get; private set; }
    public int PageIndex { get; private set; }
    public int PageSize { get; private set; }
    public int Total { get; private set; }
    public IEnumerable<T> Registers { get; private set; }

    public Pager(IEnumerable<T> registers,int total, int pageIndex,int pageSize,string search)
    {
        Registers = registers;
        Total = total;
        PageIndex = pageIndex;
        PageSize = pageSize;
        Search = search;
    }


}

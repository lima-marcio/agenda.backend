namespace Agenda.Application.Responses
{
  public class PagedResponse<T>
  {
    public List<T> Items { get; set; } = new();
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
    public string? FirstPageUrl { get; set; }
    public string? LastPageUrl { get; set; }
    public string? NextPageUrl { get; set; }
    public string? PreviousPageUrl { get; set; }

    public PagedResponse(List<T> items, int totalItems, int page, int pageSize, Func<int, int, string> urlBuilder)
    {
      Items = items;
      TotalItems = totalItems;
      Page = page;
      PageSize = pageSize;

      TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

      FirstPageUrl = urlBuilder(1, pageSize);
      LastPageUrl = urlBuilder(TotalPages, pageSize);
      NextPageUrl = page < TotalPages ? urlBuilder(page + 1, pageSize) : null;
      PreviousPageUrl = page > 1 ? urlBuilder(page - 1, pageSize) : null;
    }
  }
}

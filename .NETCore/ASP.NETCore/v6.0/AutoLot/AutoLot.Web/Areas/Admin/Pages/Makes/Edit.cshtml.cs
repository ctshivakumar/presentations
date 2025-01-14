// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Edit.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/08/09
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;

public class EditModel : BasePageModel<Make,EditModel>
{

    public EditModel(IAppLogging<EditModel> appLogging, 
        IMakeDataService makeService) 
        : base(appLogging, makeService, "Edit")
    {
    }

    public async Task OnGetAsync(int? id)
    {
        await GetOneAsync(id);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        return await SaveOneAsync(DataService.UpdateAsync);

    }
}
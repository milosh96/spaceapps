function getLaunchesForDateRange(from, to, callback)
{
    var launchUrl = `https://launchlibrary.net/1.4/launch/${from}/${to}?limit=50`;
    $.ajax(launchUrl, {
        method: "GET",
        success: function (result)
        {
            callback(result.launches);
        }
    })
}
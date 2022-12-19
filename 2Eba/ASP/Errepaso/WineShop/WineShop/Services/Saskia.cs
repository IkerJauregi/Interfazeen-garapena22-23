using Microsoft.AspNetCore.Mvc;

public class Saskia
{
    public string SaskiaId { get; set; }
    public const string CartSessionKey = "cartId";
    public static Saskia SaskiaLortu(HttpContext contestua)
    {
        var cart = new Saskia();
        cart.SaskiaId = cart.SaskiaLortuId(contestua);
        return cart;
    }
    public static Saskia SaskiaLortu(Controller controller)
    {
        return SaskiaLortu(controller.HttpContext);
    }
    public string SaskiaLortuId(HttpContext contestua)
    {
        if (contestua.Session.GetString(CartSessionKey) == null)
        {
            if (!string.IsNullOrWhiteSpace(contestua.User.Identity.Name))
            {
                contestua.Session.SetString(CartSessionKey, contestua.User.Identity.Name);
            }
            else
            {
                Guid tempCartId = Guid.NewGuid();
                contestua.Session.SetString(CartSessionKey, tempCartId.ToString());
            }
        }
        return contestua.Session.GetString(CartSessionKey);
    }
}
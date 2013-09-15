using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DS.DataContracts;
using System.Data;
using DS.DataContracts.Responses;
using DS.DataContracts.Requests;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetProductsClient client = new GetProductsClient();
        DS.DataContracts.Requests.ProductRequest request = new DS.DataContracts.Requests.ProductRequest();
        request.ProductIDs = new List<int>();
        request.DisplayAll = true;
        DS.DataContracts.Responses.ProductResponse response = client.GetProducts(request);
        gvProducts.DataSource = BuildProductDataTable(response.Products);
        gvProducts.DataBind();

        PreformCartAction();
    }

    private void PreformCartAction()
    {
        string action = Request.QueryString["action"];
        int productID = 0;
        int.TryParse(Request.QueryString["productID"], out productID);
        switch (action)
        {
            case "RemoveProduct":
                DisplayCart(RemoveProduct(productID));
                Response.Redirect("/");
                break;

            case "AddProduct":
                DisplayCart(AddProduct(productID));
                Response.Redirect("/");
                break;

            default:
                DisplayCart();
                break;
        }
    }

    private void DisplayCart()
    {
        if (Session["CartID"] != null)
        {
            int cartID = (int)Session["CartID"];
            GetCartClient client = new GetCartClient();
            CartRequest req = new CartRequest();
            req.CartID = cartID;
            CartResponse resp = client.GetCart(req);
            DisplayCart(resp);
        }
    }

    private void DisplayCart(CartResponse c)
    {
        lblCartID.Text = c.CartID.ToString();
        lblCreateDate.Text = c.CreateDate.ToString();
        lblModifyDate.Text = c.ModifyDate.ToString();
        lblTotal.Text = c.Total.ToString();
        gvCart.DataSource = BuildProductDataTable(c.CartItems);
        gvCart.DataBind();

    }

    private DataTable BuildProductDataTable(IEnumerable<Product> products)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ProductID", typeof(int));
        dt.Columns.Add("ProductNumber", typeof(string));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("Price", typeof(decimal));

        foreach (Product p in products)
        {
            DataRow dr = dt.NewRow();
            dr["ProductID"] = p.ProductID;
            dr["ProductNumber"] = p.ProductNumber;
            dr["Name"] = p.Name;
            dr["Description"] = p.Description;
            dr["Price"] = p.Price;

            dt.Rows.Add(dr);
        }
        return dt;
    }


    protected void btnCreateCart_Click1(object sender, EventArgs e)
    {
        CreateCartClient client = new CreateCartClient();
        CartResponse c = client.CreateCart();
        DisplayCart(c);
        Session["CartID"] = c.CartID;
    }

    private CartResponse RemoveProduct(int productID)
    {
        RemoveProductClient client = new RemoveProductClient();
        CartProductRequest req = new CartProductRequest();
        req.CartID = (int)Session["CartID"];
        req.ProductID = productID;
        CartResponse resp = client.RemoveProduct(req);
        return resp;
    }

    private CartResponse AddProduct(int productID)
    {
        AddProductClient client = new AddProductClient();
        CartProductRequest req = new CartProductRequest();
        req.CartID = (int)Session["CartID"];
        req.ProductID = productID;
        CartResponse resp = client.AddProduct(req);
        return resp;
    }
}
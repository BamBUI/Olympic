using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OlympicGame
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		//Грузим данные из текстбокса чтобы создать массив, в который рандомим числа от 0-я до последнего элемента в базе Questions
		protected void Button1_Click(object sender, EventArgs e)
		{
			string messageToGameForm = "game.aspx?QuestionNumber=" + TextBox1.Text;
			Response.Redirect(messageToGameForm);
		}

		//Нужно создать метод, в котором у нас будет создаваться новая строчка в таблице Game, где значение было бы 0. Так-как игра началась.
	}
}
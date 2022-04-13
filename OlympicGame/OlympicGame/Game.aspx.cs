using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OlympicGame
{
	public partial class Game : System.Web.UI.Page
	{
		//Подключаемся к библиотеке
		SqlConnection connection = new SqlConnection("Server=Paul-PC;Database=OlympicQuiz;Trusted_Connection=True;");

		//Переменная для создания массива (в массиве рандомно будут храниться значения, эти значения сопостовляем с id из таблицы Questions и выбираем их для игры)
		private int Question_Number;

		protected void Page_Load(object sender, EventArgs e)
		{
			int n;

			Question_Number = Convert.ToInt32(Request.QueryString["QuestionNumber"]);

			connection.Open();

			//Получаем сколько всего элементов в таблице Questions, так мы зададим границы рандома
			SqlCommand comm = new SqlCommand("SELECT count(*) FROM Questions", connection);

			n = Convert.ToInt32(comm);

			//Вызываем метод для создания массива рандомных Id вопросов.
			create_array(Question_Number, n);

			
		}

		//Метод создания массива. Может создать одно и то же значение, поэтому стоит дописать.
		public int[] create_array(int QuestionNumber, int n)
		{
			Random rand = new Random();
			int[] array = new int[Question_Number - 1];
			for (int i = 0; i < Question_Number; i++)
			{
				array[i] = rand.Next(0, n);
			}
			return array;
		}

		//Метод вызова вопросов и ответов к нему.
		public void load_question_answers(int[] array)
		{

			//Открываем подключение
			connection.Open();

			//Нам нужно сделать так, чтобы при загрузке у нас переписывался текст в Label и кнопках. В кнопках должны быть ответы на вопрос. По нажатию кнопки "Следующий вопрос"-
			//данные должны поменяться на следующий вопрос.
			for (int i = 0; i < array.Length; i++)
			{

				//Получаем Title под значением в array[i] - так же стоит ввести запись выбранного нами вопроса, его id и прочее в табличку GameSession
				SqlCommand getTitle = new SqlCommand("SELECT Title FROM Question WHERE id =" + array[i], connection);
				SqlDataReader titleReader = getTitle.ExecuteReader();

				//Запись текста в Label1.
				while (titleReader.Read())
				{
					Label1.Text = titleReader[0].ToString();
				}
				titleReader.Close();

				//Получаем данные из Title таблицы Answers. Нужно как-то применить флаг значения isRight. Для этого надо создать событие при нажите на кнопку -
				//которое бы проверяло этот флаг. Возможно для этого стоит создать дополнительный массив, сохраняющий в себе под каким id находятся title в Answer.
				for (int j = 0; j < array.Length; j++)
				{
					SqlCommand getAnswer = new SqlCommand("SELECT Title FROM Answers WHERE id =" + array[i], connection);
					SqlDataReader answerReader = getTitle.ExecuteReader();

					while (answerReader.Read())
					{
						Button1.Text = answerReader[0].ToString();
						Button2.Text = answerReader[0].ToString();
						Button3.Text = answerReader[0].ToString();
						Button4.Text = answerReader[0].ToString();

					}
				}



				//Для корректной работы и перехода на страницу результат нужно сделать проверку, ответили ли мы на все вопросы? В Game меняем значение только при этой проверке.

		}
	}
}
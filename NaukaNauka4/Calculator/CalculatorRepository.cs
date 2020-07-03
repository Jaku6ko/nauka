using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Calculator
{
    public class CalculatorRepository
    {
        private SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=JAKUB\SQLEXPRESS;
                Initial Catalog=calculations;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False"
                );
        }
        public void Store(Calculation calc)
        {
            string commandLine = string.Format("INSERT INTO calculations VALUES({0}, {1}, {2})", calc.InputOne.ToString("0.##").Replace(",","."),
                calc.InputTwo.ToString("0.##").Replace(",", "."), (int)calc.Type);
            var connection = getConnection();
            var command = new SqlCommand(commandLine, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<Calculation> List(int Limit = 5)
        {
            var calcs = new List<Calculation>();
            string commandLine = string.Format("SELECT TOP {0} * FROM calculations ORDER BY Id DESC", Limit);
            var connection = getConnection();
            var command = new SqlCommand(commandLine, connection);
            connection.Open();
            var result = command.ExecuteReader();
            while (result.Read())
            {
                calcs.Add(FillCalc(result));
            }
            connection.Close();
            return calcs;
        }
        public Calculation FillCalc(SqlDataReader result)
        {
            var calc = new Calculation();
            calc.InputOne = (double)result.GetValue(1);
            calc.InputTwo = (double)result.GetValue(2);
            calc.Type = (TypeEnum)result.GetValue(3);
            return calc;
        }
    }
}

package accesoJDBC;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Main {

	public static void main(String[] args) {
		try {
			Class.forName("org.sqlite.JDBC");
			Connection connection = DriverManager.getConnection("jdbc:sqlite:C:\\Users\\Alumno\\Desktop\\repositorios\\2dam\\Java\\Acceso a datos\\accesoJDBC\\test.db");
			java.sql.Statement statement =connection.createStatement();
			
			//statement.executeUpdate("update ...");
			//statement.execute("create table ..");
			
			ResultSet resultSet = statement.executeQuery("SELECT * FROM tabla1");
			while(resultSet.next()) {
				System.out.println("Persona1: "+ resultSet.getString("campo1"));
				System.out.println("Persona2: "+ resultSet.getString("campo2"));
				System.out.println();
			}
			//connection.close();
		}catch (SQLException | ClassNotFoundException e) {
			e.printStackTrace();
		}

	}

}

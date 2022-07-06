/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package BancoDados;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Hellysson
 */
public class ConexaoMysql {
     public static Connection getConexao() throws SQLException {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            System.out.println("Conectando ao Banco");
            return DriverManager.getConnection("jdbc:mysql://localhost/dbAlunos", "root", "admin");
            
        } catch (ClassNotFoundException e) {
            throw new SQLException(e.getMessage());
        }
    }

    public static void main(String[] args) throws SQLException{
        getConexao();
        System.out.println("ok");
    }
}

//String URL = "jdbc:mysql://mysql-{your-environment-name}.{hoster_domain}/{dbname}";
//DriverManager.getConnection(URL, user_name,user_password);
//localiza.jelastic.websolute.net.br
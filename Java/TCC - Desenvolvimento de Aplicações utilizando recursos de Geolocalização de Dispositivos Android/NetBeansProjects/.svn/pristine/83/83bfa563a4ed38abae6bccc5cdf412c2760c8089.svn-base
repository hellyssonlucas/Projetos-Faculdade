package Servlet;

import Entidade.Aluno;
import Entidade.Localizacao;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Date;
import java.sql.Time;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityTransaction;
import javax.persistence.Query;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import util.JPAUtil;
import util.JSFUtil;

@WebServlet(name = "RecebeDados", urlPatterns = {"/RecebeDados"})
public class RecebeDados extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

        resp.setContentType("text/html");
        PrintWriter out = resp.getWriter();

        String matriculaAndroid = req.getParameter("matricula");
        String latitudeAndroid = req.getParameter("latitude");
        String longitudeAndroid = req.getParameter("longitude");
        String dataAndroid = req.getParameter("data");
        String horaAndroid = req.getParameter("hora");

        EntityManager em = null;
        EntityTransaction etx = null;
        try {
            em = JPAUtil.getEM();
            etx = em.getTransaction();
            etx.begin();

            Query query = em.createQuery(" select a from Aluno a");
            List<Aluno> alunos = query.getResultList();

            for (Aluno aluno : alunos) {

                if (aluno.getMatricula().equals(matriculaAndroid.toString())) {
                    Localizacao loc = new Localizacao();
                    loc.setAlunoidAluno(aluno);
                    loc.setLatitude(Double.valueOf(latitudeAndroid.toString()));
                    loc.setLongitude(Double.valueOf(longitudeAndroid.toString()));
                    loc.setData(Date.valueOf(dataAndroid));
                    loc.setHora(Time.valueOf(horaAndroid));
                    em.persist(loc);
                    etx.commit();
                    
                } else {
                    out.print("matricula nao encontrada na base");
                }
            }
         
        } catch (Exception e) {
            JSFUtil.addMessage("Erro: " + e.getMessage());

        } finally {
            if (em != null) {
                em.close();
            }
        }
        out.close();
    }
}


            //String latitudeAndroid = "-18.956907";
            //String longitudeAndroid = "-48.275127";
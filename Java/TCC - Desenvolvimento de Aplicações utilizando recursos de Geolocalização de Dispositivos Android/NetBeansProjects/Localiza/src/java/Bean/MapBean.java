/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Bean;

import Entidade.Aluno;
import Entidade.Localizacao;
import java.util.Date;
import java.util.List;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import org.primefaces.model.map.DefaultMapModel;
import org.primefaces.model.map.LatLng;
import org.primefaces.model.map.MapModel;
import org.primefaces.model.map.Marker;
import util.JPAUtil;
import util.JSFUtil;

/**
 *
 * @author Hellysson
 */
@ManagedBean
@RequestScoped
public class MapBean {

    private MapModel simpleModel;
    Localizacao localizacao = new Localizacao();
    Aluno aluno = new Aluno();

    public Aluno getAluno() {
        return aluno;
    }

    public void setAluno(Aluno aluno) {
        this.aluno = aluno;
    }
    public int numero = 1;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    //**************************************************************************************   
    public void mostrarAluno() {

        simpleModel = new DefaultMapModel();
        EntityManager em = null;

        em = JPAUtil.getEM();

        if (aluno.getMatricula().isEmpty()) {

            JSFUtil.addMessage("Antes da consulta voce deve digitar uma matricula");

        } else {
            Query query1 = em.createQuery(" select a from Aluno a where a.matricula = " + aluno.getMatricula());
            List<Aluno> alunos = query1.getResultList();
            Aluno alunoBuscado = alunos.get(0);
            System.out.println(alunoBuscado.toString());

            int idBuscado = alunoBuscado.getIdAluno();

            Query query = em.createQuery(" select l from Localizacao l where l.alunoidAluno.idAluno = " + idBuscado + " order by l.data DESC, l.hora DESC ").setMaxResults(numero);

            List<Localizacao> locais = query.getResultList();
            Localizacao local = locais.get(0);
            System.out.println(local.toString());

            for (Localizacao dados : locais) {

                Double lat = dados.getLatitude();
                Double lng = dados.getLongitude();

                String nome = alunoBuscado.getNome();
                Date data = dados.getData();
                Date hora = dados.getHora();

                String novaData = String.format("%1$td/%1$tm/%1$tY", data);
                String novaHora = String.format("%1$tH:%1$tM:%1$tS", hora);

                System.out.println(data);
                System.out.println(hora);

                LatLng coord1 = new LatLng(lat, lng);
                simpleModel.addOverlay(new Marker(coord1, " Aluno: " + nome + " Data: "
                        + novaData.toString() + " Hora: " + novaHora.toString()));
            }
            em.close();
        }
    }
    //**************************************************************************************  

    public MapBean() {

        simpleModel = new DefaultMapModel();


        //Shared coordinates
        LatLng coord1 = new LatLng(-18.956907, -48.275127);
        LatLng coord2 = new LatLng(-18.956986, -48.271882);
        LatLng coord3 = new LatLng(-18.956813, -48.270493);
        LatLng coord4 = new LatLng(-18.957318, -48.271037);
        LatLng coord5 = new LatLng(-18.956724, -48.271458);

        //Basic marker
        simpleModel.addOverlay(new Marker(coord1, "Walmart"));
        simpleModel.addOverlay(new Marker(coord2, "Unitri1"));
        simpleModel.addOverlay(new Marker(coord3, "Unitri2"));
        simpleModel.addOverlay(new Marker(coord4, "Unitri3"));
        simpleModel.addOverlay(new Marker(coord5, "Unitri4"));
    }

    public MapModel getSimpleModel() {
        return simpleModel;
    }
//**************************************************************************************    

    public void mostrarTodos() {

        simpleModel = new DefaultMapModel();
        EntityManager em = null;

        em = JPAUtil.getEM();

        Query query = em.createQuery(" select l from Localizacao l ");
        List<Localizacao> locais = query.getResultList();

        Query query1 = em.createQuery(" select a from Aluno a");
        List<Aluno> alunos = query1.getResultList();

        for (Localizacao dados : locais) {

            for (Aluno dados1 : alunos) {

                int idLoc = dados.getAlunoidAluno().getIdAluno();
                int idAlu = dados1.getIdAluno();

                if (idLoc == idAlu) {
                    
                    Double lat = dados.getLatitude();
                    Double lng = dados.getLongitude();

                    String nome = dados1.getNome();
                    Date data = dados.getData();
                    Date hora = dados.getHora();

                    String novaData = String.format("%1$td/%1$tm/%1$tY", data);
                    String novaHora = String.format("%1$tH:%1$tM:%1$tS", hora);

                    System.out.println(novaData);
                    System.out.println(novaHora);

                    LatLng coord1 = new LatLng(lat, lng);
                    simpleModel.addOverlay(new Marker(coord1, " Aluno: " + nome + " Data: "
                            + novaData.toString() + " Hora: " + novaHora.toString()));

                }
            }
        }
        em.close();
    }

    public void mostrarUltimoTodos() {

        simpleModel = new DefaultMapModel();
        EntityManager em = null;
        em = JPAUtil.getEM();

        Query query1 = em.createQuery(" select a from Aluno a ");
        List<Aluno> alunos = query1.getResultList();
        
        System.out.println("\n\nDados de ultima localização dos Alunos \n");
        
        for (Aluno dados1 : alunos) {
            for (int i = 0; i < alunos.size(); i++) {

                Aluno alunoBuscado = alunos.get(i);
                int idBuscado = alunoBuscado.getIdAluno();

                Query query = em.createQuery(" select l from Localizacao l where l.alunoidAluno.idAluno = " + idBuscado + " order by l.data DESC, l.hora DESC ").setMaxResults(1);
                List<Localizacao> locais = query.getResultList();
                
                for (Localizacao dados : locais) {
                    Localizacao local = locais.get(0);
                   
                    int idLoc = dados.getAlunoidAluno().getIdAluno();
                    int idAlu = dados1.getIdAluno();
                    
                    if (idLoc == idAlu) {
                        
                        String nome = dados1.getNome();                        
                        Double lat = dados.getLatitude();
                        Double lng = dados.getLongitude();
                        Date data = dados.getData();
                        Date hora = dados.getHora();
                     
                        String novaData = String.format("%1$td/%1$tm/%1$tY", data);
                        String novaHora = String.format("%1$tH:%1$tM:%1$tS", hora);
                        
                        LatLng coord1 = new LatLng(lat, lng);
                        simpleModel.addOverlay(new Marker(coord1, " Aluno: " + nome + " Data: "
                                + novaData.toString() + " Hora: " + novaHora.toString()));
                        
                        System.out.println("Aluno: " + alunoBuscado.getNome() + "\nMatricula: " + alunoBuscado.getMatricula());
                        System.out.println("Latitude: " + local.getLatitude()+ "\nLongitude: " + local.getLongitude());
                        System.out.println("Data: " + novaData + "\nHora: " + novaHora + "\n");
                      }
                }
            }
        }
        em.close();

    }
}

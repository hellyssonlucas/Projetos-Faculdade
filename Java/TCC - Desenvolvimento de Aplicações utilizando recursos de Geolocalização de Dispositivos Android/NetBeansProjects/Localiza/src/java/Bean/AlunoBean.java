/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Bean;

import Entidade.Aluno;
import java.util.List;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import javax.persistence.EntityManager;
import javax.persistence.EntityTransaction;
import javax.persistence.Query;
import util.JPAUtil;
import util.JSFUtil;

/**
 *
 * @author Hellysson
 */
@ManagedBean
@RequestScoped
public class AlunoBean {

   private Aluno aluno = new Aluno();

    public Aluno getAluno() {
        return aluno;
    }

    public void setAluno(Aluno aluno) {
        this.aluno = aluno;
    }

    
    public AlunoBean() {
    }
    
   //**********************************************************************************************************    
    public String salvar() {
        
        if (aluno.getMatricula().isEmpty()|| aluno.getNome().isEmpty() || aluno.getEndereco().isEmpty()
                || aluno.getTelefone().isEmpty()){
                          
                JSFUtil.addMessage("Falta preencher algum dado para Salvar");
            
            } else {     
        
        EntityManager em = null;
        EntityTransaction etx = null;
        try {
            em = JPAUtil.getEM();
            etx = em.getTransaction();
            etx.begin();
            
         List<Aluno> alunos = em.createNamedQuery("Aluno.findByMatricula").setParameter("matricula", aluno.getMatricula()).getResultList();
            if (alunos != null && alunos.size() > 0) {
                Aluno alunoBuscado = alunos.get(0);

                if (alunoBuscado.getMatricula().equals(aluno.getMatricula())) {
                    JSFUtil.addSessionAttrib("matricula", alunoBuscado);
                   JSFUtil.addMessage("Matrícula ja cadastrada no sistema");
                    limpaCampos();
                   return null;          
                }
                
            }else
                
                if(aluno.getIdAluno()== -1) {
              
                em.persist(aluno);
            
                } else {
            
                em.merge(aluno);
                }
                
                etx.commit();
            JSFUtil.addMessage("Aluno Salvo com Sucesso.!");
           limpaCampos();
                  
              } catch (Exception e) {
            etx.rollback();
            JSFUtil.addMessage("Erro: " + e.getMessage());
        } finally {
            if (em != null) {
                em.close();
                            }
     }
                
    }
        return null;
}

  //**********************************************************************************************************   
    public String novo(){
        
        limpaCampos();
        aluno = new Aluno();
        return "cadastro";
    }
 //**********************************************************************************************************    
   public void limpaCampos(){
            aluno.setIdAluno(null); 
            aluno.setMatricula(null);
            aluno.setNome(null);
            aluno.setEndereco(null);
            aluno.setTelefone(null);
   
   }
//**********************************************************************************************************  
     public String voltar(){
      
        return "cadastro";
     }
//**********************************************************************************************************
     public void mostrarAluno(){
         
         if (aluno.getMatricula().isEmpty()){
               
                JSFUtil.addMessage("Digite uma matricula primeiro!!");
            
            } else {
         
         
             EntityManager em = null;
             EntityTransaction etx = null;
       
            em = JPAUtil.getEM();
            etx = em.getTransaction();
            etx.begin();
            
            List<Aluno> alunos = em.createNamedQuery("Aluno.findByMatricula").setParameter("matricula", aluno.getMatricula()).getResultList();
            if (alunos != null && alunos.size() > 0) {
                Aluno alunoBuscado = alunos.get(0);
                                
                       aluno.setMatricula(alunoBuscado.getMatricula());
                       aluno.setNome(alunoBuscado.getNome());
                       aluno.setEndereco(alunoBuscado.getEndereco());
                       aluno.setTelefone(alunoBuscado.getTelefone());
                       
              }
         }   
     }
     
 //**********************************************************************************************************     
     public String apagar() {
         
          if (aluno.getMatricula().isEmpty()){
               
                JSFUtil.addMessage("Para remover digite uma matricula primeiro!!");
            
       } else {
        
         EntityManager em = null;
         EntityTransaction etx = null;
        
            em = JPAUtil.getEM();
            etx = em.getTransaction();
            etx.begin();
            
           Query query1 = em.createQuery (" select a from Aluno a where a.matricula = " + aluno.getMatricula());
                 List <Aluno > alunos = query1. getResultList ();
                 Aluno alunoBuscado = alunos.get(0);
                 System.out.println(alunoBuscado.toString());
                 em.remove(alunoBuscado);

        etx.commit();
        limpaCampos();
        
         JSFUtil.addMessage("Aluno Removido com sucesso");
        em.close();
          }  
    return null;
    
   }

}     
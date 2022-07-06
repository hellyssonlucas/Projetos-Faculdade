package Entidade;

import Entidade.Localizacao;
import javax.annotation.Generated;
import javax.persistence.metamodel.ListAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-05-09T15:27:17")
@StaticMetamodel(Aluno.class)
public class Aluno_ { 

    public static volatile SingularAttribute<Aluno, Integer> idAluno;
    public static volatile SingularAttribute<Aluno, String> telefone;
    public static volatile SingularAttribute<Aluno, String> nome;
    public static volatile ListAttribute<Aluno, Localizacao> localizacaoList;
    public static volatile SingularAttribute<Aluno, String> endereco;
    public static volatile SingularAttribute<Aluno, String> matricula;

}
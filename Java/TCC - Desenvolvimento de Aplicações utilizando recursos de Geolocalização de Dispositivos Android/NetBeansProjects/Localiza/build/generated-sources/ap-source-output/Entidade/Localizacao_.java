package Entidade;

import Entidade.Aluno;
import java.util.Date;
import javax.annotation.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-05-09T15:27:17")
@StaticMetamodel(Localizacao.class)
public class Localizacao_ { 

    public static volatile SingularAttribute<Localizacao, Date> hora;
    public static volatile SingularAttribute<Localizacao, Integer> idLocalizacao;
    public static volatile SingularAttribute<Localizacao, Date> data;
    public static volatile SingularAttribute<Localizacao, Double> longitude;
    public static volatile SingularAttribute<Localizacao, Double> latitude;
    public static volatile SingularAttribute<Localizacao, Aluno> alunoidAluno;

}
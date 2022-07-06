/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Entidade;

import java.io.Serializable;
import java.util.Date;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

/**
 *
 * @author Hellysson
 */
@Entity
@Table(name = "localizacao")
@NamedQueries({
    @NamedQuery(name = "Localizacao.findAll", query = "SELECT l FROM Localizacao l"),
    @NamedQuery(name = "Localizacao.findByIdLocalizacao", query = "SELECT l FROM Localizacao l WHERE l.idLocalizacao = :idLocalizacao"),
    @NamedQuery(name = "Localizacao.findByLatitude", query = "SELECT l FROM Localizacao l WHERE l.latitude = :latitude"),
    @NamedQuery(name = "Localizacao.findByLongitude", query = "SELECT l FROM Localizacao l WHERE l.longitude = :longitude"),
    @NamedQuery(name = "Localizacao.findByData", query = "SELECT l FROM Localizacao l WHERE l.data = :data"),
    @NamedQuery(name = "Localizacao.findByHora", query = "SELECT l FROM Localizacao l WHERE l.hora = :hora")})
public class Localizacao implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "idLocalizacao")
    private Integer idLocalizacao;
    // @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
    @Column(name = "latitude")
    private Double latitude;
    @Column(name = "longitude")
    private Double longitude;
    @Column(name = "data")
    @Temporal(TemporalType.DATE)
    private Date data;
    @Column(name = "hora")
    @Temporal(TemporalType.TIME)
    private Date hora;
    @JoinColumn(name = "Aluno_idAluno", referencedColumnName = "idAluno")
    @ManyToOne(optional = false)
    private Aluno alunoidAluno;

    public Localizacao() {
    }

    public Localizacao(Double latitude, Double longitude, Date data, Date hora, Aluno alunoidAluno) {
        this.latitude = latitude;
        this.longitude = longitude;
        this.data = data;
        this.hora = hora;
        this.alunoidAluno = alunoidAluno;
    }

    public Localizacao(Integer idLocalizacao) {
        this.idLocalizacao = idLocalizacao;
    }

    public Integer getIdLocalizacao() {
        return idLocalizacao;
    }

    public void setIdLocalizacao(Integer idLocalizacao) {
        this.idLocalizacao = idLocalizacao;
    }

    public Double getLatitude() {
        return latitude;
    }

    public void setLatitude(Double latitude) {
        this.latitude = latitude;
    }

    public Double getLongitude() {
        return longitude;
    }

    public void setLongitude(Double longitude) {
        this.longitude = longitude;
    }

    public Date getData() {
        return data;
    }

    public void setData(Date data) {
        this.data = data;
    }

    public Date getHora() {
        return hora;
    }

    public void setHora(Date hora) {
        this.hora = hora;
    }

    public Aluno getAlunoidAluno() {
        return alunoidAluno;
    }

    public void setAlunoidAluno(Aluno alunoidAluno) {
        this.alunoidAluno = alunoidAluno;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idLocalizacao != null ? idLocalizacao.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Localizacao)) {
            return false;
        }
        Localizacao other = (Localizacao) object;
        if ((this.idLocalizacao == null && other.idLocalizacao != null) || (this.idLocalizacao != null && !this.idLocalizacao.equals(other.idLocalizacao))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Entidade.Localizacao[ idLocalizacao=" + idLocalizacao + " ]";
    }
    
}

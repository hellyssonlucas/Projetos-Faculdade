/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package util;

import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;

/**
 *
 * @author curso
 */
public class JPAUtil {

    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("LocalizaPU");

    public static EntityManager getEM(){
        if(emf == null) {
            emf = Persistence.createEntityManagerFactory("LocalizaPU");
        }
        return emf.createEntityManager();
    }

}

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package util;

import javax.faces.application.FacesMessage;
import javax.faces.context.FacesContext;
import javax.servlet.http.HttpSession;

/**
 *
 * @author curso
 */
public class JSFUtil {

    public static void addMessage(String msg) {
        FacesContext.getCurrentInstance().addMessage(null, new FacesMessage(msg));
    }

    public static void addMessage(String compId, String msg) {
        FacesContext.getCurrentInstance().addMessage(compId, new FacesMessage(msg));
    }

    public static void addSessionAttrib(String key, Object value){
        FacesContext.getCurrentInstance().getExternalContext().getSessionMap().put(key, value);
    }

    public static void sessionInvalidate(){
        try {
            ((HttpSession)FacesContext.getCurrentInstance().getExternalContext().getSession(false)).invalidate();
        } catch(Exception e){
            System.out.println("Erro no logout!");
        }
    }
}

    using JetBrains.Annotations;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class Split : MonoBehaviour
{
    public string[] listaNumeros;

    public string referencia;

    public int[] DatoPos;
    public int[] pos;

    public int[] PosGuardada;

    public bool genero;
    public int genNum;

    public GameObject[] accesorios_Reloj;
    public GameObject[] accesorios_Maleta;
    public GameObject[] ropas_F;
    public GameObject[] ropas_M;
    public GameObject[] cabezas_F;
    public GameObject[] cabezas_M;
    public GameObject[] cejas_F;
    public GameObject[] cejas_M;
    public GameObject[] pelos_F;
    public GameObject[] pelos_M;
    public GameObject[] sombreros;
    public GameObject[] zapatos;

    [ContextMenu("Convertir")]

    public void Start()
    {
        DatoPos = new int[12];
        pos = new int[12];

       
        pos[2] = PlayerPrefs.GetInt("ropas_f", 0);
        pos[3] = PlayerPrefs.GetInt("ropas_m", 0);
        pos[4] = PlayerPrefs.GetInt("cabezas_f", 0);
        pos[5] = PlayerPrefs.GetInt("cabezas_m", 0);
        pos[6] = PlayerPrefs.GetInt("cejas_f", 0);
        pos[7] = PlayerPrefs.GetInt("cejas_m", 0);
        pos[8] = PlayerPrefs.GetInt("pelos_f", 0);
        pos[9] = PlayerPrefs.GetInt("pelos_m", 0);



        Gen();
    }

    public void Covertir()
    {
        listaNumeros = referencia.Split("|");
        //0
        int indice = int.Parse(listaNumeros[0]);
        for (int i = 0; i < accesorios_Reloj.Length; i++)
        {
            accesorios_Reloj[i].SetActive(indice == i);
        }
        //1
        indice = int.Parse(listaNumeros[1]);
        for (int i = 0; i < accesorios_Maleta.Length; i++)
        {
            accesorios_Maleta[i].SetActive(indice == i);
        }
        //2
        indice = int.Parse(listaNumeros[2]);
        for (int i = 0; i < ropas_F.Length; i++)
        {
            ropas_F[i].SetActive(indice == i);
        }
        //3
        indice = int.Parse(listaNumeros[3]);
        for (int i = 0; i < ropas_M.Length; i++)
        {
            ropas_M[i].SetActive(indice == i);
        }
        //4
        indice = int.Parse(listaNumeros[4]);
        for (int i = 0; i < cabezas_F.Length; i++)
        {
            cabezas_F[i].SetActive(indice == i);
        }
        //5
        indice = int.Parse(listaNumeros[5]);
        for (int i = 0; i < cabezas_M.Length; i++)
        {
            cabezas_M[i].SetActive(indice == i);
        }
        //6
        indice = int.Parse(listaNumeros[6]);
        for (int i = 0; i < cejas_F.Length; i++)
        {
            cejas_F[i].SetActive(indice == i);
        }
        //7
        indice = int.Parse(listaNumeros[7]);
        for (int i = 0; i < cejas_M.Length; i++)
        {
            cejas_M[i].SetActive(indice == i);
        }
        //8
        indice = int.Parse(listaNumeros[8]);
        for (int i = 0; i < pelos_F.Length; i++)
        {
            pelos_F[i].SetActive(indice == i);
        }
        //9
        indice = int.Parse(listaNumeros[9]);
        for (int i = 0; i < pelos_M.Length; i++)
        {
            pelos_M[i].SetActive(indice == i);
        }//10
        indice = int.Parse(listaNumeros[10]);
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(indice == i);
        }
        //11
        indice = int.Parse(listaNumeros[11]);
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(indice == i);
        }
    }

    public void accesorios() 
    {
       
            pos[0]++;

            DatoPos[0] = pos[0];

            if (pos[0] > ropas_F.Length - 1)
            {
                pos[0] = 0;
            }

            for (int i = 0; i < ropas_F.Length; i++)
            {
                ropas_F[i].SetActive(pos[0] == i);
            }
            PlayerPrefs.SetInt("ropas_f", pos[0]);
   
    }
    public void Ropa()
    {
        if (genero)
        {
            pos[2]++;

            DatoPos[2] = pos[2];

            if (pos[2] > ropas_F.Length - 1)
            {
                pos[2] = 0;
            }

            for (int i = 0; i < ropas_F.Length; i++)
            {
                ropas_F[i].SetActive(pos[2] == i);
            }
            PlayerPrefs.SetInt("ropas_f", pos[2]);
        }
        else
        {
            pos[3]++;

            DatoPos[3] = pos[3];

            if (pos[3] > ropas_M.Length - 1)
            {
                pos[3] = 0;
            }

            for (int i = 0; i < ropas_M.Length; i++)
            {
                ropas_M[i].SetActive(pos[3] == i);
            }
            PlayerPrefs.SetInt("ropas_m", pos[3]);
        }
    }

    public void Cabeza()
    {
        if (genero)
        {
            pos[4]++;

            DatoPos[4] = pos[4];

            if (pos[4] > cabezas_F.Length - 1)
            {
                pos[4] = 0;
            }

            for (int i = 0; i < cabezas_F.Length; i++)
            {
                cabezas_F[i].SetActive(pos[4] == i);
            }
            PlayerPrefs.SetInt("cabezas_f", pos[4]);
        }
        else
        {
            pos[5]++;

            DatoPos[5] = pos[5];

            if (pos[5] > cabezas_M.Length - 1)
            {
                pos[5] = 0;
            }

            for (int i = 0; i < cabezas_M.Length; i++)
            {
                cabezas_M[i].SetActive(pos[5] == i);
            }
            PlayerPrefs.SetInt("cabezas_m", pos[5]);
        }
    }

    public void Cejas()
    {
        if (genero)
        {
            pos[6]++;

            DatoPos[6] = pos[6];

            if (pos[6] > cejas_F.Length - 1)
            {
                pos[6] = 0;
            }

            for (int i = 0; i < cejas_F.Length; i++)
            {
                cejas_F[i].SetActive(pos[6] == i);
            }
            PlayerPrefs.SetInt("cejas_f", pos[6]);
        }
        else
        {
            pos[7]++;

            DatoPos[7] = pos[7];

            if (pos[7] > cejas_M.Length - 1)
            {
                pos[7] = 0;
            }

            for (int i = 0; i < cejas_M.Length; i++)
            {
                cejas_M[i].SetActive(pos[7] == i);
            }
            PlayerPrefs.SetInt("cejas_m", pos[7]);
        }
    }

    public void Pelos()
    {
        if (genero)
        {
            pos[8]++;

            DatoPos[8] = pos[8];

            if (pos[8] > pelos_F.Length - 1)
            {
                pos[8] = 0;
            }

            for (int i = 0; i < pelos_F.Length; i++)
            {
                pelos_F[i].SetActive(pos[8] == i);
            }
            PlayerPrefs.SetInt("pelos_f", pos[8]);
        }
        else
        {
            pos[9]++;

            DatoPos[9] = pos[9];

            if (pos[9] > pelos_M.Length - 1)
            {
                pos[9] = 0;
            }

            for (int i = 0; i < pelos_M.Length; i++)
            {
                pelos_M[i].SetActive(pos[9] == i);
            }
            PlayerPrefs.SetInt("pelos_m", pos[9]);
        }
    }


    public void TomarDatos()
    {   //0
        for (int i = 0; i < accesorios_Reloj.Length; i++)
        {
            accesorios_Reloj[i].SetActive(pos[0] == i);
        }
        //1
      
        for (int i = 0; i < accesorios_Maleta.Length; i++)
        {
            accesorios_Maleta[i].SetActive(pos[1] == i);
        }
        //2
        for (int i = 0; i < ropas_F.Length; i++)
        {
            ropas_F[i].SetActive(pos[2] == i);
        }
        //3

        for (int i = 0; i < ropas_M.Length; i++)
        {
            ropas_M[i].SetActive(pos[3] == i);
        }
        //4
      
        for (int i = 0; i < cabezas_F.Length; i++)
        {
            cabezas_F[i].SetActive(pos[4] == i);
        }
        //5
       
        for (int i = 0; i < cabezas_M.Length; i++)
        {
            cabezas_M[i].SetActive(pos[5] == i);
        }
        //6
     
        for (int i = 0; i < cejas_F.Length; i++)
        {
            cejas_F[i].SetActive(pos[6] == i);
        }
        //7
       
        for (int i = 0; i < cejas_M.Length; i++)
        {
            cejas_M[i].SetActive(pos[7] == i);
        }
        //8
      
        for (int i = 0; i < pelos_F.Length; i++)
        {
            pelos_F[i].SetActive(pos[8] == i);
        }
        //9
    
        for (int i = 0; i < pelos_M.Length; i++)
        {
            pelos_M[i].SetActive(pos[9] == i);
        }//10
       
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(pos[10] == i);
        }
        //11
      
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(pos[11] == i);
        }
    }

    public void Masculino() 
    {
        genero = false;
        PlayerPrefs.SetInt("genero", 0);
        
        Gen();
    }
    public void Femenino() 
    {
        genero = true;
        PlayerPrefs.SetInt("genero", 1);
        Gen();
    }

    public void Gen()
    {
        genNum = PlayerPrefs.GetInt("genero", 0);
        if (genNum == 1)
        {
            genero = true;
        }
        else
        {
            genero = false;
        }
        TomarDatos();
        if (!genero)
        {
            for (int i = 0; i < ropas_F.Length; i++)
            {
                ropas_F[i].SetActive(false);
            }
            for (int i = 0; i < cabezas_F.Length; i++)
            {
                cabezas_F[i].SetActive(false);
            }
            for (int i = 0; i < cejas_F.Length; i++)
            {
                cejas_F[i].SetActive(false);

            }
            for (int i = 0; i < pelos_F.Length; i++)
            {
                pelos_F[i].SetActive(false);
            }
        }

        if (genero)
        {
            for (int i = 0; i < ropas_M.Length; i++)
            {
                ropas_M[i].SetActive(false);
            }
            for (int i = 0; i < cabezas_M.Length; i++)
            {
                cabezas_M[i].SetActive(false);
            }
            for (int i = 0; i < cejas_M.Length; i++)
            {
                cejas_M[i].SetActive(false);

            }
            for (int i = 0; i < pelos_M.Length; i++)
            {
                pelos_M[i].SetActive(false);
            }
        }
    }
}

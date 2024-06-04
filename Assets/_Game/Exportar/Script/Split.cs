    using JetBrains.Annotations;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class Split : MonoBehaviour
{
    //??
    public string[] listaNumeros;
    public string referencia;
    public int[] PosGuardada;

    //??
    public int[] DatoPos;
    public int[] pos;

    

    //variables para identificar el genero
    public bool genero;
    public int genNum;

    //Arrays para almacenar todos los objetos de cada caracteristica
    public GameObject[] accesorios_Reloj;
    public GameObject[] maleta_F;
    public GameObject[] maleta_M;
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
        DatoPos = new int[13];
        pos = new int[13];


        pos[0] = PlayerPrefs.GetInt("reloj", 0);
        pos[1] = PlayerPrefs.GetInt("maleta_f", 0);
        pos[2] = PlayerPrefs.GetInt("maleta_m", 0);
        pos[3] = PlayerPrefs.GetInt("ropas_f", 0);
        pos[4] = PlayerPrefs.GetInt("ropas_m", 0);
        pos[5] = PlayerPrefs.GetInt("cabezas_f", 0);
        pos[6] = PlayerPrefs.GetInt("cabezas_m", 0);
        pos[7] = PlayerPrefs.GetInt("cejas_f", 0);
        pos[8] = PlayerPrefs.GetInt("cejas_m", 0);
        pos[9] = PlayerPrefs.GetInt("pelos_f", 0);
        pos[10] = PlayerPrefs.GetInt("pelos_m", 0);
        pos[11] = PlayerPrefs.GetInt("sombrero", 0);
        pos[12] = PlayerPrefs.GetInt("zapatos", 0);



        Gen();
    }

    //???
    /*
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
        for (int i = 0; i < maleta_F.Length; i++)
        {
            maleta_F[i].SetActive(indice == i);
        }
        //2
        indice = int.Parse(listaNumeros[2]);
        for (int i = 0; i < maleta_M.Length; i++)
        {
            maleta_M[i].SetActive(indice == i);
        }
        //3
        indice = int.Parse(listaNumeros[3]);
        for (int i = 0; i < ropas_F.Length; i++)
        {
            ropas_F[i].SetActive(indice == i);
        }
        //4
        indice = int.Parse(listaNumeros[4]);
        for (int i = 0; i < ropas_M.Length; i++)
        {
            ropas_M[i].SetActive(indice == i);
        }
        //5
        indice = int.Parse(listaNumeros[5]);
        for (int i = 0; i < cabezas_F.Length; i++)
        {
            cabezas_F[i].SetActive(indice == i);
        }
        //6
        indice = int.Parse(listaNumeros[6]);
        for (int i = 0; i < cabezas_M.Length; i++)
        {
            cabezas_M[i].SetActive(indice == i);
        }
        //7
        indice = int.Parse(listaNumeros[7]);
        for (int i = 0; i < cejas_F.Length; i++)
        {
            cejas_F[i].SetActive(indice == i);
        }
        //8
        indice = int.Parse(listaNumeros[8]);
        for (int i = 0; i < cejas_M.Length; i++)
        {
            cejas_M[i].SetActive(indice == i);
        }
        //9
        indice = int.Parse(listaNumeros[9]);
        for (int i = 0; i < pelos_F.Length; i++)
        {
            pelos_F[i].SetActive(indice == i);
        }
        //10
        indice = int.Parse(listaNumeros[10]);
        for (int i = 0; i < pelos_M.Length; i++)
        {
            pelos_M[i].SetActive(indice == i);
        }//11
        indice = int.Parse(listaNumeros[11]);
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(indice == i);
        }
        //12
        indice = int.Parse(listaNumeros[12]);
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(indice == i);
        }
    }

    */


    //Metodo invocado desde BtnReloj para el cambio de estilo del reloj
    public void Reloj() 
    {
        //Asignamos la posicion
        pos[0]++;

        // ???
        DatoPos[0] = pos[0];

        //Si sobrepasa el tamaño del array lo volvemos a cero
        if (pos[0] > accesorios_Reloj.Length - 1)
        {
            pos[0] = 0;
        }

        //Al presionar el botón Pasamos y activamos uno a uno los estilos
        for (int i = 0; i < accesorios_Reloj.Length; i++)
        {
            accesorios_Reloj[i].SetActive(pos[0] == i);
        }
        //Guardamos el ultimo item elegido
        PlayerPrefs.SetInt("reloj", pos[0]);

    }

    //Metodo invocado desde BtnMaleta para el cambio de estilo de la maleta
    public void Maleta()
    {
        //Validamos si es Femenino o Masculino
        if (genero)
        {
            //Asignamos la posicion
            pos[1]++;

            // ???
            DatoPos[1] = pos[1];

            //Si sobrepasa el tamaño del array lo volvemos a cero
            if (pos[1] > maleta_F.Length - 1)
            {
                pos[1] = 0;
            }

            //Al presionar el botón Pasamos y activamos uno a uno los estilos
            for (int i = 0; i < maleta_F.Length; i++)
            {
                maleta_F[i].SetActive(pos[1] == i);
            }
            //Guardamos el ultimo item elegido
            PlayerPrefs.SetInt("maleta_f", pos[1]);
        }
        else
        {
            pos[2]++;

            DatoPos[2] = pos[2];

            if (pos[2] > maleta_M.Length - 1)
            {
                pos[2] = 0;
            }

            for (int i = 0; i < maleta_M.Length; i++)
            {
                maleta_M[i].SetActive(pos[2] == i);
            }
            PlayerPrefs.SetInt("maleta_m", pos[2]);
        }
    }
   
    //Metodo invocado desde BtnCuerpo para el cambio de estilo de la ropa
    public void Ropa()
    {
        //Validamos si es Femenino o Masculino
        if (genero)
        {
            //Asignamos la posicion
            pos[3]++;

            // ???
            DatoPos[3] = pos[3];

            //Si sobrepasa el tamaño del array lo volvemos a cero
            if (pos[3] > ropas_F.Length - 1)
            {
                pos[3] = 0;
            }

            //Al presionar el botón Pasamos y activamos uno a uno los estilos
            for (int i = 0; i < ropas_F.Length; i++)
            {
                ropas_F[i].SetActive(pos[3] == i);
            }
            //Guardamos el ultimo item elegido
            PlayerPrefs.SetInt("ropas_f", pos[3]);
        }
        else
        {
            pos[4]++;

            DatoPos[4] = pos[4];

            if (pos[4] > ropas_M.Length - 1)
            {
                pos[4] = 0;
            }

            for (int i = 0; i < ropas_M.Length; i++)
            {
                ropas_M[i].SetActive(pos[4] == i);
            }
            PlayerPrefs.SetInt("ropas_m", pos[4]);
        }
    }

    //Metodo invocado desde BtnCabeza para el cambio de estilo de la cara
    public void Cabeza()
    {
        //Validamos si es Femenino o Masculino
        if (genero)
        {
            //Asignamos la posicion
            pos[5]++;

            // ???
            DatoPos[5] = pos[5];

            //Si sobrepasa el tamaño del array lo volvemos a cero
            if (pos[5] > cabezas_F.Length - 1)
            {
                pos[5] = 0;
            }

            //Al presionar el botón Pasamos y activamos uno a uno los estilos
            for (int i = 0; i < cabezas_F.Length; i++)
            {
                cabezas_F[i].SetActive(pos[5] == i);
            }
            //Guardamos el ultimo item elegido
            PlayerPrefs.SetInt("cabezas_f", pos[5]);
        }
        else
        {
            pos[6]++;

            DatoPos[6] = pos[6];

            if (pos[6] > cabezas_M.Length - 1)
            {
                pos[6] = 0;
            }

            for (int i = 0; i < cabezas_M.Length; i++)
            {
                cabezas_M[i].SetActive(pos[6] == i);
            }
            PlayerPrefs.SetInt("cabezas_m", pos[6]);
        }
    }

    //Metodo invocado desde BtnCejas para el cambio de estilo de las cejas
    public void Cejas()
    {
        //Validamos si es Femenino o Masculino
        if (genero)
        {
            //Asignamos la posicion
            pos[7]++;

            // ???
            DatoPos[7] = pos[7];

            //Si sobrepasa el tamaño del array lo volvemos a cero
            if (pos[7] > cejas_F.Length - 1)
            {
                pos[7] = 0;
            }

            //Al presionar el botón Pasamos y activamos uno a uno los estilos
            for (int i = 0; i < cejas_F.Length; i++)
            {
                cejas_F[i].SetActive(pos[7] == i);
            }
            //Guardamos el ultimo item elegido
            PlayerPrefs.SetInt("cejas_f", pos[7]);
        }
        else
        {
            pos[8]++;

            DatoPos[8] = pos[8];

            if (pos[8] > cejas_M.Length - 1)
            {
                pos[8] = 0;
            }

            for (int i = 0; i < cejas_M.Length; i++)
            {
                cejas_M[i].SetActive(pos[8] == i);
            }
            PlayerPrefs.SetInt("cejas_m", pos[8]);
        }
    }

    //Metodo invocado desde BtnPelos para el cambio de estilo del peinado
    public void Pelos()
    {
        //Validamos si es Femenino o Masculino
        if (genero)
        {
            //Asignamos la posicion
            pos[9]++;

            // ???
            DatoPos[9] = pos[9];

            //Si sobrepasa el tamaño del array lo volvemos a cero
            if (pos[9] > pelos_F.Length - 1)
            {
                pos[9] = 0;
            }

            //Al presionar el botón Pasamos y activamos uno a uno los estilos
            for (int i = 0; i < pelos_F.Length; i++)
            {
                pelos_F[i].SetActive(pos[9] == i);
            }
            //Guardamos el ultimo item elegido
            PlayerPrefs.SetInt("pelos_f", pos[9]);
        }
        else
        {
            pos[10]++;

            DatoPos[10] = pos[10];

            if (pos[10] > pelos_M.Length - 1)
            {
                pos[10] = 0;
            }

            for (int i = 0; i < pelos_M.Length; i++)
            {
                pelos_M[i].SetActive(pos[10] == i);
            }
            PlayerPrefs.SetInt("pelos_m", pos[10]);
        }
    }

    //Metodo invocado desde BtnSombrero para el cambio de estilo del sombrero
    public void Sombrero()
    {
        //Asignamos la posicion
        pos[11]++;

        // ???
        DatoPos[11] = pos[11];

        //Si sobrepasa el tamaño del array lo volvemos a cero
        if (pos[11] > sombreros.Length - 1)
        {
            pos[11] = 0;
        }

        //Al presionar el botón Pasamos y activamos uno a uno los estilos
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(pos[11] == i);
        }
        //Guardamos el ultimo item elegido
        PlayerPrefs.SetInt("sombrero", pos[11]);
    }

    //Metodo invocado desde BtnZapatos para el cambio de estilo de zapatos
    public void Zapatos()
    {
        //Asignamos la posicion
        pos[12]++;

        // ???
        DatoPos[12] = pos[12];

        //Si sobrepasa el tamaño del array lo volvemos a cero
        if (pos[12] > zapatos.Length - 1)
        {
            pos[12] = 0;
        }

        //Al presionar el botón Pasamos y activamos uno a uno los estilos
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(pos[12] == i);
        }
        //Guardamos el ultimo item elegido
        PlayerPrefs.SetInt("zapatos", pos[12]);
    }


    public void TomarDatos()
    {   //0
        for (int i = 0; i < accesorios_Reloj.Length; i++)
        {
            accesorios_Reloj[i].SetActive(pos[0] == i);
        }
        //1
        for (int i = 0; i < maleta_F.Length; i++)
        {
            maleta_F[i].SetActive(pos[1] == i);
        }
        //2
        for (int i = 0; i < maleta_M.Length; i++)
        {
            maleta_M[i].SetActive(pos[2] == i);
        }
        //3
        for (int i = 0; i < ropas_F.Length; i++)
        {
            ropas_F[i].SetActive(pos[3] == i);
        }
        //4
        for (int i = 0; i < ropas_M.Length; i++)
        {
            ropas_M[i].SetActive(pos[4] == i);
        }
        //5
        for (int i = 0; i < cabezas_F.Length; i++)
        {
            cabezas_F[i].SetActive(pos[5] == i);
        }
        //6     
        for (int i = 0; i < cabezas_M.Length; i++)
        {
            cabezas_M[i].SetActive(pos[6] == i);
        }
        //7 
        for (int i = 0; i < cejas_F.Length; i++)
        {
            cejas_F[i].SetActive(pos[7] == i);
        }
        //8
        for (int i = 0; i < cejas_M.Length; i++)
        {
            cejas_M[i].SetActive(pos[8] == i);
        }
        //9
        for (int i = 0; i < pelos_F.Length; i++)
        {
            pelos_F[i].SetActive(pos[9] == i);
        }
        //10 
        for (int i = 0; i < pelos_M.Length; i++)
        {
            pelos_M[i].SetActive(pos[10] == i);
        }//11   
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(pos[11] == i);
        }
        //12  
        for (int i = 0; i < zapatos.Length; i++)
        {
            zapatos[i].SetActive(pos[12] == i);
        }
    }

    //Cambiar genero a Maculino
    public void Masculino() 
    {
        genero = false;
        PlayerPrefs.SetInt("genero", 0);
        
        Gen();
    }

    //Cambiar genero a Femenino
    public void Femenino() 
    {
        genero = true;
        PlayerPrefs.SetInt("genero", 1);
        Gen();
    }

    public void Gen()
    {
        //Obtenemos el genero para saber el ultimo escogido
        genNum = PlayerPrefs.GetInt("genero", 0);

        //Validamos si es 1 = Femenino, 0 = Maculino
        if (genNum == 1)
        {
            genero = true;
        }
        else
        {
            genero = false;
        }

        //Traemos los datos
        TomarDatos();

        //Si no es femenino desactivamos los objetos de ese genero
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
            for (int i = 0; i < maleta_F.Length; i++)
            {
                maleta_F[i].SetActive(false);
            }
        }

        //Si no es masculino desactivamos los objetos de ese genero
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
            for (int i = 0; i < maleta_M.Length; i++)
            {
                maleta_M[i].SetActive(false);
            }
        }
    }
}

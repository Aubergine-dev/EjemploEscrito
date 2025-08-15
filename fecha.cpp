#include "../include/fecha.h"

struct rep_fecha {
    nat dia, mes, anio;
};
// Inicio del espacio de funciones auxiliares

//Funcion que, dada un anio, determina si es bisiesto o no.
static bool esBisiesto(nat anio) {
    if ((anio % 400) == 0) {
        return true; //Bisiesto
    } else if ((anio % 100) == 0) {
        return false; //No bisiesto
    } else if ((anio % 4) == 0) {
        return true; //Bisiesto
    }

    return false;
}

//Funcion que, dado un mes y un anio, determina los dias del mes correspondiente.
static nat diasMes(nat mes, nat anio) {
    nat dias;
    switch (mes) 
    {
        case 1: case 3: case 5: case 7: case 8: case 10: case 12: //Enero, Marzo, Mayo, Julio, Agosto, Octubre, Diciembre
            dias = 31;
        break;

        case 2: // Febrero
            if (esBisiesto(anio)) {
                dias = 29;
            } else {
                dias = 28;
            }
        break;

        case 4: case 6: case 9: case 11: //Abril, Junio, Septiembre, Noviembre
            dias = 30;
        break;
    }

    return dias;
}

// Pasa una fecha del formato d/m/aaaa a el formato aaaammdd
static nat convertirFecha(TFecha fecha) {
    nat fecha_num = (fecha->anio * 10000) + (fecha->mes * 100) + fecha->dia;

    return fecha_num;
}

// Fin del espacio de funciones auxiliares

TFecha crearTFecha(nat dia, nat mes, nat anio) {
    TFecha nuevaFecha = new rep_fecha;
    nuevaFecha->dia = dia;
    nuevaFecha->mes = mes;
    nuevaFecha->anio = anio;
    return nuevaFecha;
}

void liberarTFecha(TFecha &fecha) {
    delete fecha;
    fecha = NULL;
}
void imprimirTFecha(TFecha fecha) {
    nat dia = fecha->dia;
    nat mes = fecha->mes;
    nat anio = fecha->anio;

    printf("%u/%u/%u\n", dia, mes, anio);
}

TFecha copiarTFecha(TFecha fecha) {
    TFecha copia = new rep_fecha;
    copia->dia = fecha->dia;
    copia->mes = fecha->mes;
    copia->anio = fecha->anio;
    return copia;
}

void aumentarTFecha(TFecha &fecha, nat dias) {
    fecha->dia += dias;

    while(fecha->dia > diasMes(fecha->mes, fecha->anio)) {
        fecha->dia -= diasMes(fecha->mes, fecha->anio);
        fecha->mes++;

        if (fecha->mes > 12) {
            fecha->mes = 1;
            fecha->anio++;
        }
    }
}

int compararTFechas(TFecha fecha1, TFecha fecha2) {
    int res = 0;
    // 0 = las fechas son iguales. 1 = la primera fecha es mayor a la segunda. -1 = la primera fecha es anterior a la segunda

    nat fecha1_num = convertirFecha(fecha1);
    nat fecha2_num = convertirFecha(fecha2);

    if (fecha1_num > fecha2_num) {
        res = 1;
    } else if (fecha1_num < fecha2_num) {
        res = -1;
    }
    return res;
}

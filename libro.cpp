#include "../include/libro.h"

struct rep_libro {
    int ISBN;
    char Titulo[MAX_TITULO];
    char NombreAutor[MAX_NOMBRE_AUTOR];
    char ApellidoAutor[MAX_APELLIDO_AUTOR];
    char Descripcion[MAX_DESCRIPCION];
    int IDGeneroLibro;
    TFecha FechaEdicion;
};

// Crea y retorna un elemento de tipo TLibro con los valores dados
TLibro crearTLibro(int isbn, const char titulo[MAX_TITULO], const char nombreAutor[MAX_NOMBRE_AUTOR], const char apellidoAutor[MAX_APELLIDO_AUTOR], const char descripcion[MAX_DESCRIPCION], int idGeneroLibro, TFecha fechaEdicion){
    TLibro NuevoLibro=new rep_libro;
    NuevoLibro->ISBN=isbn;
    strcpy(NuevoLibro->Titulo, titulo);
    strcpy(NuevoLibro->NombreAutor, nombreAutor);
    strcpy(NuevoLibro->ApellidoAutor, apellidoAutor);
    strcpy(NuevoLibro->Descripcion, descripcion);
    NuevoLibro->IDGeneroLibro=idGeneroLibro;
    NuevoLibro->FechaEdicion=fechaEdicion;
    return NuevoLibro;
}

// Libera la memoria asignada para el libro 'l'
// Debe liberar también la memoria de la fecha asociada
void liberarTLibro(TLibro &l){
    liberarTFecha(l->FechaEdicion);
    delete l;
    l=NULL;
}

// Retorna el isbn del libro 'l'
int isbnTLibro(TLibro l){
    return l->ISBN;
}

// Retorna el titulo del libro 'l'
// El titulo retornado comparte memoria con el parámetro. 
char* tituloTLibro(TLibro l){
    return l->Titulo;
}

// Retorna la descripción del libro 'l'
// La descripción retornada comparte memoria con el parámetro. 
char* descripcionTLibro(TLibro l){
    return l->Descripcion; 
}

// Retorna el nombre del autor del libro 'l'
// El nombre retornado comparte memoria con el parámetro. 
char* nombreAutorTLibro(TLibro l){
    return l->NombreAutor;
}

// Retorna el apellido del autor del libro 'l'
// El apellido retornado comparte memoria con el parámetro. 
char* apellidoAutorTLibro(TLibro l){
    return l->ApellidoAutor;
}

// Retorna el id del género del libro 'l'
int idGeneroTLibro(TLibro l){
    return l->IDGeneroLibro;
}

// Retorna la fecha de edición del libro 'l'.
// La fecha retornada comparte memoria con el parámetro. 
TFecha fechaEdicionTLibro(TLibro l){
    return l->FechaEdicion;
}

// Imprime la información del libro 'l' en el siguiente formato:
// Libro <isbn> 
// Título: <título>
// Autor: <nombre autor> <apellido autor>
// Descripción: <descripcion>
// Género: <id género>
// Fecha de edición: <fecha de edición>
void imprimirTLibro(TLibro l){
    printf("Libro %d\nTítulo: %s\nAutor: %s %s\nDescripción: %s\nGénero: %d\nFecha de edición: ", l->ISBN, l->Titulo, l->NombreAutor, l->ApellidoAutor, l->Descripcion, l->IDGeneroLibro);
imprimirTFecha(l->FechaEdicion);
}

// Retorna una copia del libro 'l' que no comparte memoria con el parámetro.
TLibro copiarTLibro(TLibro l){
    TFecha nFecha=copiarTFecha(l->FechaEdicion);
    TLibro Copia=crearTLibro(l->ISBN,l->Titulo,l->NombreAutor,l->ApellidoAutor,l->Descripcion,l->IDGeneroLibro,nFecha);
    return Copia;
}

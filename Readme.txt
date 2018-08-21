1-Dentro de los metodos getDatos y eliminarDatos se debe cambiar el string de conexion a la base de datos ya que figura 
la ruta de mi computadora y al momento de usarlo en otra va a resultar en un error.
No tenia conocimientos en base de datos en .Net, por lo que busque como hacerlo y me encotre con este problema que no pude resolver.

2-Las canciones se almacenan dentro de la base de datos guardando la ruta en donde se encuentran.
La manera correcta seria guardar la cancion en si como  byte[] y luego reconstruirla y reproducirla.
Por falta de tiempo y conocimientos no pude realizarlo de esta manera.
Para no generar errores, valide que si no existe la ruta de la cancion informe al usuario de esta situacion.
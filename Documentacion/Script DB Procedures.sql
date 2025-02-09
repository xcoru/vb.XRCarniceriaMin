#    ________________________________________________________________________________________________________________________________________
#   /PROCEDIMIENTOS ALMACENADOS *********PROCEDIMIENTOS ALMACENADOS*********PROCEDIMIENTOS ALMACENADOS********PROCEDIMIENTOS ALMACENADOS*****\
#  --------------------------------------------------------------------------------------------------------------------------------------------


#TABLA ARTICULO *********** TABLA ARTICULO *********** TABLA ARTICULO *********************************************************************************



DROP PROCEDURE IF EXISTS articulo_mostrar;
 DELIMITER //
CREATE PROCEDURE articulo_mostrar()
   BEGIN
		SELECT 
			id_articulo		AS	 'ID',
			descripcion		AS	 'Descripcion',
			tipo 			AS	 'Tipo',
			precio 			AS	 'Precio',
			imagen 			AS	 'Imagen',
			estado 			AS	 'Estado'
		FROM articulo;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_consultar;
 DELIMITER //
CREATE PROCEDURE articulo_consultar(IN id_ VARCHAR(20))
   BEGIN
		SELECT 
			id_articulo		AS	 'ID',
			descripcion		AS	 'Descripcion',
			tipo 			AS	 'Tipo',
			precio 			AS	 'Precio',
			imagen 			AS	 'Imagen',
			estado 			AS	 'Estado'
		FROM articulo 
        WHERE id_articulo = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_insertar;
 DELIMITER //
CREATE PROCEDURE articulo_insertar(
	IN campo1   VARCHAR(20), 
    IN campo2	VARCHAR(120),
    IN campo3 	VARCHAR(20),
		IN campo4 	DEC(10,2),
		IN campo5 	VARCHAR(500),
    IN campo6 	INT
)
   BEGIN
		INSERT INTO articulo(
			id_articulo, 
			descripcion, 
			tipo, 
			precio,
			imagen,
			estado
            ) 
		VALUES(
			campo1,
			campo2,
			campo3,
			campo4,
			campo5,
			campo6
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_editar;
 DELIMITER //
CREATE PROCEDURE articulo_editar(
	IN campo1   VARCHAR(20), 
    IN campo2	VARCHAR(120),
    IN campo3 	VARCHAR(20),
		IN campo4 	DEC(10,2),
		IN campo5 	VARCHAR(500),
    IN campo6 	INT
)
   BEGIN
		UPDATE articulo SET 
			descripcion 	= campo2, 
			tipo			= campo3, 
			precio			= campo4, 
			imagen		= campo5,
			estado			= campo6
		WHERE id_articulo  = campo1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_eliminar;
 DELIMITER //
CREATE PROCEDURE articulo_eliminar(IN id_ VARCHAR(20))
   BEGIN
		DELETE FROM articulo WHERE id_articulo = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_filtrar;
 DELIMITER //
CREATE PROCEDURE articulo_filtrar(
	IN cadena VARCHAR(150)
)
   BEGIN
		SELECT 
			id_articulo		AS	 'ID',
			descripcion		AS	 'Descripcion',
			tipo 			AS	 'Tipo',
			precio 			AS	 'Precio',
			imagen 			AS	 'Imagen',
			estado 			AS	 'Estado'
        FROM articulo WHERE CONCAT_WS(' ',id_articulo, descripcion) LIKE CONCAT('%',cadena,'%') LIMIT 5;
   END //
DELIMITER ;




#TABLA USUARIO *********** TABLA USUARIO ***********TABLA USUARIO*********************************************************************************



DROP PROCEDURE IF EXISTS usuario_mostrar;
 DELIMITER //
CREATE PROCEDURE usuario_mostrar()
   BEGIN
		SELECT 
			id_usuario		AS	 'Usuario',
			nombre			AS	 'Nombre',
			password 		AS	 'Contraseña',
			estado 			AS	 'Estado'
		FROM usuario;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_consultar;
 DELIMITER //
CREATE PROCEDURE usuario_consultar(IN id_ VARCHAR(20))
   BEGIN
		SELECT 
			id_usuario		AS	 'Usuario',
			nombre			AS	 'Nombre',
			password 		AS	 'Contraseña',
			estado 			AS	 'Estado'
		FROM usuario 
        WHERE id_usuario = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_login;
 DELIMITER //
CREATE PROCEDURE usuario_login(IN id_ VARCHAR(20), IN pass_ VARCHAR(20))
   BEGIN
		SELECT 
			id_usuario		AS	 'Usuario',
			nombre			AS	 'Nombre',
			password 		AS	 'Contraseña',
			estado 			AS	 'Estado'
		FROM usuario 
        WHERE id_usuario = id_ AND password=pass_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_insertar;
 DELIMITER //
CREATE PROCEDURE usuario_insertar(
	IN campo1   VARCHAR(20), 
    IN campo2	VARCHAR(120),
    IN campo3 	VARCHAR(20),
    IN campo4 	INT
)
   BEGIN
		INSERT INTO usuario(
			id_usuario, 
			nombre, 
			password,
			estado
            ) 
		VALUES(
			campo1,
			campo2,
			campo3,
			campo4
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_editar;
 DELIMITER //
CREATE PROCEDURE usuario_editar(
	IN campo1   VARCHAR(20), 
    IN campo2	VARCHAR(120),
    IN campo3 	VARCHAR(20),
    IN campo4 	INT
)
   BEGIN
		UPDATE usuario SET 
			nombre 			= campo2, 
			password		= campo3, 
			estado			= campo4
		WHERE id_usuario  	= campo1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_eliminar;
 DELIMITER //
CREATE PROCEDURE usuario_eliminar(IN id_ VARCHAR(20))
   BEGIN
		DELETE FROM usuario WHERE id_usuario = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_filtrar;
 DELIMITER //
CREATE PROCEDURE usuario_filtrar(
	IN cadena VARCHAR(150)
)
   BEGIN
		SELECT 
			id_usuario		AS	 'ID',
			nombre			AS	 'Usuario',
			password 		AS	 'Contraseña',
			estado 			AS	 'Estado'
        FROM usuario WHERE  CONCAT_WS(' ',id_usuario, nombre) LIKE CONCAT('%',cadena,'%') LIMIT 5;
   END //
DELIMITER ;



#TABLA NEGOCIO *********** TABLA NEGOCIO ***********TABLA NEGOCIO *********************************************************************************



DROP PROCEDURE IF EXISTS negocio_mostrar;
 DELIMITER //
CREATE PROCEDURE negocio_mostrar()
   BEGIN
		SELECT 
			id_negocio		AS	 'ID',
			nombre			AS	 'Nombre',
			descripcion		AS	 'Descripcion',
			direccion 		AS	 'Dirección',
			telefono 		AS	 'Telefono',
			logotipo 		AS	 'Logotipo'
		FROM negocio;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS negocio_consultar;
 DELIMITER //
CREATE PROCEDURE negocio_consultar(IN id_ INT)
   BEGIN
		SELECT 
			id_negocio		AS	 'ID',
			nombre			AS	 'Nombre',
			descripcion		AS	 'Descripcion',
			direccion 		AS	 'Dirección',
			telefono 		AS	 'Telefono',
			logotipo 		AS	 'Logotipo'
		FROM negocio 
        WHERE id_negocio = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS negocio_insertar;
 DELIMITER //
CREATE PROCEDURE negocio_insertar(
	IN campo1   VARCHAR(120), 
    IN campo2	VARCHAR(250),
    IN campo3 	VARCHAR(250),
	IN campo4 	VARCHAR(12),
    IN campo5 	VARCHAR(500)
)
   BEGIN
		INSERT INTO negocio(
			nombre, 
			descripcion, 
			direccion, 
			telefono, 
			logotipo
            ) 
		VALUES(
			campo1,
			campo2,
			campo3,
			campo4,
			campo5
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS negocio_editar;
 DELIMITER //
CREATE PROCEDURE negocio_editar(
	IN campo1   INT,
	IN campo2   VARCHAR(120), 
    IN campo3	VARCHAR(250),
    IN campo4 	VARCHAR(250),
	IN campo5 	VARCHAR(12),
    IN campo6 	VARCHAR(500)
)
   BEGIN
		UPDATE negocio SET 
			nombre			= campo2,
			descripcion 	= campo3, 
			direccion		= campo4, 
			telefono		= campo5, 
			logotipo		= campo6
		WHERE id_negocio    = campo1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS negocio_eliminar;
 DELIMITER //
CREATE PROCEDURE negocio_eliminar(IN id_ INT)
   BEGIN
		DELETE FROM negocio WHERE id_negocio = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS negocio_filtrar;
 DELIMITER //
CREATE PROCEDURE negocio_filtrar(
	IN cadena VARCHAR(150)
)
   BEGIN
		SELECT 
			id_negocio		AS	 'ID',
			nombre			AS	 'Nombre',
			descripcion		AS	 'Descripcion',
			direccion 		AS	 'Dirección',
			telefono 		AS	 'Telefono',
			logotipo 		AS	 'Logotipo'
        FROM negocio WHERE CONCAT_WS(' ',nombre, descripcion) LIKE CONCAT('%',cadena,'%') LIMIT 5;
   END //
DELIMITER ;



#TABLA CONFIG *********** TABLA CONFIG ***********TABLA CONFIG *********************************************************************************



DROP PROCEDURE IF EXISTS config_mostrar;
 DELIMITER //
CREATE PROCEDURE config_mostrar()
   BEGIN
		SELECT 
			id_config		AS	 'ID',
			impresora		AS	 'Impresora'
		FROM config;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS config_consultar;
 DELIMITER //
CREATE PROCEDURE config_consultar(IN id_ INT)
   BEGIN
		SELECT 
			id_config		AS	 'ID',
			impresora		AS	 'Impresora'
		FROM config 
        WHERE id_config = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS config_insertar;
 DELIMITER //
CREATE PROCEDURE config_insertar(
	IN campo1 INT,
    IN campo2 VARCHAR(120)
)
   BEGIN
		INSERT INTO config(
			id_config,
			impresora
            ) 
		VALUES(
			campo1,
			campo2
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS config_editar;
 DELIMITER //
CREATE PROCEDURE config_editar(
	IN campo1   INT,
	IN campo2   VARCHAR(120)
)
   BEGIN
		UPDATE config SET 
			impresora		= campo2
		WHERE id_config     = campo1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS config_eliminar;
 DELIMITER //
CREATE PROCEDURE config_eliminar(IN id_ INT)
   BEGIN
		DELETE FROM config WHERE id_config = id_;
   END //
DELIMITER ;



#TABLA VENTAS *********** TABLA VENTAS ***********TABLA VENTAS *********************************************************************************



DROP PROCEDURE IF EXISTS ventas_mostrar;
 DELIMITER //
CREATE PROCEDURE ventas_mostrar()
   BEGIN
		SELECT 
			id_venta	AS	 'Id',
			folio		AS	 'Folio',
			id_usuario 	AS	 'Usuario',
			id_articulo AS	 'Id Articulo',
			precio		AS	 'Precio',
			cantidad 	AS	 'Cantidad',
			subtotal	AS	 'SubTotal',
			hora		AS	 'Hora',
			fecha		AS	 'Fecha'
		FROM ventas;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_consultar;
 DELIMITER //
CREATE PROCEDURE ventas_consultar(IN id_ VARCHAR(20))
   BEGIN
		SELECT 
			id_venta	AS	 'Id',
			folio		AS	 'Folio',
			id_usuario 	AS	 'Usuario',
			id_articulo AS	 'Id Articulo',
			precio		AS	 'Precio',
			cantidad 	AS	 'Cantidad',
			subtotal	AS	 'SubTotal',
			hora		AS	 'Hora',
			fecha		AS	 'Fecha'
		FROM ventas 
        WHERE folio = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_insertar;
 DELIMITER //
CREATE PROCEDURE ventas_insertar(
	IN campo1   INT, 
    IN campo2	VARCHAR(20),
    IN campo3 	VARCHAR(20),
	IN campo4 	VARCHAR(20),
    IN campo5 	DEC(10,2),
	IN campo6 	FLOAT(10,3),
	IN campo7 	DEC(10,2),
	IN campo8 	VARCHAR(20),
	IN campo9 	DATE
)
   BEGIN
		INSERT INTO ventas(
			folio, 
			id_usuario, 
			id_articulo, 
			precio,
			cantidad, 
			subtotal,
			hora,
			fecha
            ) 
		VALUES(
			campo2,
			campo3,
			campo4,
			campo5,
			campo6,
			campo7,
			campo8,
			campo9
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_editar;
 DELIMITER //
CREATE PROCEDURE ventas_editar(
	IN campo1   INT, 
    IN campo2	VARCHAR(20),
    IN campo3 	VARCHAR(20),
	IN campo4 	VARCHAR(20),
    IN campo5 	DEC(10,2),
	IN campo6 	FLOAT(10,3),
	IN campo7 	DEC(10,2),
	IN campo8 	VARCHAR(20),
	IN campo9 	DATE
)
   BEGIN
		UPDATE ventas SET 
			folio 			= campo2, 
			id_usuario		= campo3, 
			id_articulo		= campo4, 
			precio			= campo5,
			cantidad		= campo6, 
			subtotal		= campo7,
			hora			= campo8,
			fecha			= campo9
		WHERE id_venta  	= campo1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_eliminar;
 DELIMITER //
CREATE PROCEDURE ventas_eliminar(IN id_ VARCHAR(20))
   BEGIN
		DELETE FROM ventas WHERE folio = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_filtrar;
 DELIMITER //
CREATE PROCEDURE ventas_filtrar(
	IN fecha_ini DATE,
	IN fecha_fin DATE
)
   BEGIN
		SELECT 
			id_venta	AS	 'Id',
			folio		AS	 'Folio',
			id_usuario 	AS	 'Usuario',
			id_articulo AS	 'Id Articulo',
			precio		AS	 'Precio',
			cantidad 	AS	 'Cantidad',
			subtotal	AS	 'SubTotal',
			hora		AS	 'Hora',
			fecha		AS	 'Fecha'
        FROM ventas WHERE fecha BETWEEN fecha_ini AND fecha_fin LIMIT 1000;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_getFolio;
 DELIMITER //
CREATE PROCEDURE ventas_getFolio()
   BEGIN
		SELECT MAX(folio) + 1 AS 'FOLIO' 
		FROM ventas;

   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ventas_corte_caja;
 DELIMITER //
CREATE PROCEDURE ventas_corte_caja(
	IN _fecha DATE
)
   BEGIN
		SELECT 
			a.folio AS "Folio",
			a.id_articulo AS "Clave A.", 
			b.descripcion AS "Producto", 
			b.precio AS "Precio", 
			a.cantidad AS "Cantidad",
			b.tipo AS "U.M.",
			a.subtotal AS "Subtotal", 
			a.hora AS "Hora"
		FROM ventas a
		INNER JOIN articulo AS b 
		ON a.id_articulo = b.id_articulo 
		AND a.fecha = _fecha
		ORDER BY a.folio;
   END //
DELIMITER ;

#TABLA EGRESO *********** TABLA EGRESO ***********TABLA EGRESO *********************************************************************************



DROP PROCEDURE IF EXISTS egreso_mostrar;
 DELIMITER //
CREATE PROCEDURE egreso_mostrar()
   BEGIN
		SELECT 
			id_egreso	AS	 'Id',
			id_usuario 	AS	 'Usuario',
			concepto 	AS	 'Concepto',
			monto 		AS	 'Monto',
			hora		AS	 'Hora',
			fecha		AS	 'Fecha'
		FROM egreso;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS egreso_consultar;
 DELIMITER //
CREATE PROCEDURE egreso_consultar(
	IN fecha_ini DATE,
	IN fecha_fin DATE
)
   BEGIN
		SELECT 
			id_egreso	AS	 'Id',
			id_usuario 	AS	 'Usuario',
			concepto 	AS	 'Concepto',
			monto 		AS	 'Monto',
			hora		AS	 'Hora',
			fecha		AS	 'Fecha'
        FROM egreso WHERE fecha BETWEEN fecha_ini AND fecha_fin LIMIT 1000;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS egreso_insertar;
 DELIMITER //
CREATE PROCEDURE egreso_insertar(
	IN campo1	INT,
	IN campo2   VARCHAR(20), 
    IN campo3	VARCHAR(250),
    IN campo4 	DEC(10,2),
	IN campo5 	VARCHAR(20),
    IN campo6 	DATE
)
   BEGIN
		INSERT INTO egreso(
			id_usuario, 
			concepto, 
			monto, 
			hora,
			fecha
            ) 
		VALUES(
			campo2,
			campo3,
			campo4,
			campo5,
			campo6
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS egreso_editar;
 DELIMITER //
CREATE PROCEDURE egreso_editar(
	IN campo1   INT, 
	IN campo2   VARCHAR(20), 
    IN campo3	VARCHAR(250),
    IN campo4 	DEC(10,2),
	IN campo5 	VARCHAR(20),
    IN campo6 	DATE
)
   BEGIN
		UPDATE egreso SET 
			id_usuario		= campo2, 
			concepto		= campo3, 
			monto			= campo4, 
			hora			= campo5,
			fecha			= campo6
		WHERE id_egreso  	= campo1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS egreso_eliminar;
 DELIMITER //
CREATE PROCEDURE egreso_eliminar(IN id_ INT)
   BEGIN
		DELETE FROM egreso WHERE id_egreso = id_;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS egreso_filtrar;
 DELIMITER //
CREATE PROCEDURE egreso_filtrar(
	IN fecha_ini DATE,
	IN fecha_fin DATE
)
   BEGIN
		SELECT 
			id_egreso	AS	 'Id',
			id_usuario 	AS	 'Usuario',
			concepto 	AS	 'Concepto',
			monto 		AS	 'Monto',
			hora		AS	 'Hora',
			fecha		AS	 'Fecha'
        FROM egreso WHERE fecha BETWEEN fecha_ini AND fecha_fin LIMIT 1000;
   END //
DELIMITER ;


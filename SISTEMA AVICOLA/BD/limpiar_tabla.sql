ALTER TABLE comprobante AUTO_INCREMENT = 2;
ALTER TABLE detallecomprobante AUTO_INCREMENT = 1;
ALTER TABLE deuda AUTO_INCREMENT = 1;
truncate cliente;
TRUNCATE producto;
TRUNCATE unidadequivalente;
TRUNCATE precio;
SET FOREIGN_KEY_CHECKS = 0;
truncate auditoria;
truncate comprobante;
truncate detallecomprobante;
truncate deuda;
truncate cobro;
UPDATE serie set ncorrelativo=1;

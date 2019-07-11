/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50711
Source Host           : localhost:3306
Source Database       : bdsistema

Target Server Type    : MYSQL
Target Server Version : 50711
File Encoding         : 65001

Date: 2019-07-04 09:31:52
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for acceso
-- ----------------------------
DROP TABLE IF EXISTS `acceso`;
CREATE TABLE `acceso` (
  `idacceso` int(11) NOT NULL AUTO_INCREMENT,
  `idusuario` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idacceso`) USING BTREE,
  KEY `frk_idusuario05` (`idusuario`) USING BTREE,
  CONSTRAINT `frk_idusuario05` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=386 DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of acceso
-- ----------------------------
INSERT INTO `acceso` VALUES ('1', '1', '2019-04-11 21:38:22');
INSERT INTO `acceso` VALUES ('2', '1', '2019-04-11 21:49:24');
INSERT INTO `acceso` VALUES ('3', '1', '2019-04-11 21:50:49');
INSERT INTO `acceso` VALUES ('4', '1', '2019-04-11 22:00:29');
INSERT INTO `acceso` VALUES ('5', '1', '2019-04-11 22:43:40');
INSERT INTO `acceso` VALUES ('6', '1', '2019-04-11 23:07:48');
INSERT INTO `acceso` VALUES ('7', '1', '2019-04-11 23:12:26');
INSERT INTO `acceso` VALUES ('8', '1', '2019-04-13 18:02:31');
INSERT INTO `acceso` VALUES ('9', '1', '2019-04-13 18:03:36');
INSERT INTO `acceso` VALUES ('10', '1', '2019-04-13 18:05:53');
INSERT INTO `acceso` VALUES ('11', '1', '2019-04-13 18:10:15');
INSERT INTO `acceso` VALUES ('12', '1', '2019-04-13 18:17:00');
INSERT INTO `acceso` VALUES ('13', '1', '2019-04-14 20:18:14');
INSERT INTO `acceso` VALUES ('14', '1', '2019-04-14 20:24:31');
INSERT INTO `acceso` VALUES ('15', '1', '2019-04-14 20:25:48');
INSERT INTO `acceso` VALUES ('16', '1', '2019-04-16 21:47:01');
INSERT INTO `acceso` VALUES ('17', '1', '2019-04-16 21:48:28');
INSERT INTO `acceso` VALUES ('18', '1', '2019-04-16 21:51:26');
INSERT INTO `acceso` VALUES ('19', '1', '2019-04-17 22:30:21');
INSERT INTO `acceso` VALUES ('20', '1', '2019-04-17 22:32:34');
INSERT INTO `acceso` VALUES ('21', '1', '2019-04-19 13:57:30');
INSERT INTO `acceso` VALUES ('22', '1', '2019-04-19 14:09:23');
INSERT INTO `acceso` VALUES ('23', '1', '2019-04-22 20:43:18');
INSERT INTO `acceso` VALUES ('24', '1', '2019-04-22 20:57:57');
INSERT INTO `acceso` VALUES ('25', '1', '2019-04-22 20:59:21');
INSERT INTO `acceso` VALUES ('26', '1', '2019-04-22 21:05:54');
INSERT INTO `acceso` VALUES ('27', '1', '2019-04-22 21:07:51');
INSERT INTO `acceso` VALUES ('28', '1', '2019-04-22 21:08:23');
INSERT INTO `acceso` VALUES ('29', '1', '2019-04-22 21:11:58');
INSERT INTO `acceso` VALUES ('30', '1', '2019-04-22 21:13:01');
INSERT INTO `acceso` VALUES ('31', '1', '2019-04-22 21:22:27');
INSERT INTO `acceso` VALUES ('32', '1', '2019-04-22 21:24:39');
INSERT INTO `acceso` VALUES ('33', '1', '2019-04-22 21:26:22');
INSERT INTO `acceso` VALUES ('34', '1', '2019-04-22 21:27:18');
INSERT INTO `acceso` VALUES ('35', '1', '2019-04-22 21:28:02');
INSERT INTO `acceso` VALUES ('36', '1', '2019-04-22 21:33:19');
INSERT INTO `acceso` VALUES ('37', '1', '2019-04-22 21:36:57');
INSERT INTO `acceso` VALUES ('38', '1', '2019-04-22 21:42:18');
INSERT INTO `acceso` VALUES ('39', '1', '2019-04-22 21:44:28');
INSERT INTO `acceso` VALUES ('40', '1', '2019-04-22 21:46:43');
INSERT INTO `acceso` VALUES ('41', '1', '2019-04-22 21:55:40');
INSERT INTO `acceso` VALUES ('42', '1', '2019-04-22 21:56:46');
INSERT INTO `acceso` VALUES ('43', '1', '2019-04-22 22:02:37');
INSERT INTO `acceso` VALUES ('44', '1', '2019-04-24 21:13:04');
INSERT INTO `acceso` VALUES ('45', '1', '2019-04-24 21:14:14');
INSERT INTO `acceso` VALUES ('46', '1', '2019-04-24 22:08:05');
INSERT INTO `acceso` VALUES ('47', '1', '2019-04-24 22:16:57');
INSERT INTO `acceso` VALUES ('48', '1', '2019-04-24 22:24:40');
INSERT INTO `acceso` VALUES ('49', '1', '2019-04-24 22:48:52');
INSERT INTO `acceso` VALUES ('50', '1', '2019-04-24 22:49:56');
INSERT INTO `acceso` VALUES ('51', '1', '2019-04-24 22:53:45');
INSERT INTO `acceso` VALUES ('52', '1', '2019-04-24 22:55:14');
INSERT INTO `acceso` VALUES ('53', '1', '2019-04-24 23:13:09');
INSERT INTO `acceso` VALUES ('54', '1', '2019-04-24 23:43:16');
INSERT INTO `acceso` VALUES ('55', '1', '2019-04-26 15:13:46');
INSERT INTO `acceso` VALUES ('56', '1', '2019-04-26 21:51:52');
INSERT INTO `acceso` VALUES ('57', '1', '2019-04-26 22:18:37');
INSERT INTO `acceso` VALUES ('58', '1', '2019-04-26 22:30:12');
INSERT INTO `acceso` VALUES ('59', '1', '2019-04-27 10:45:11');
INSERT INTO `acceso` VALUES ('60', '1', '2019-04-27 11:00:26');
INSERT INTO `acceso` VALUES ('61', '1', '2019-04-27 11:05:13');
INSERT INTO `acceso` VALUES ('62', '1', '2019-04-27 11:18:11');
INSERT INTO `acceso` VALUES ('63', '1', '2019-04-27 11:26:06');
INSERT INTO `acceso` VALUES ('64', '1', '2019-04-27 12:06:14');
INSERT INTO `acceso` VALUES ('65', '1', '2019-04-27 12:13:40');
INSERT INTO `acceso` VALUES ('66', '1', '2019-04-27 12:16:13');
INSERT INTO `acceso` VALUES ('67', '1', '2019-04-27 12:18:17');
INSERT INTO `acceso` VALUES ('68', '1', '2019-04-27 12:29:38');
INSERT INTO `acceso` VALUES ('69', '1', '2019-04-27 20:34:03');
INSERT INTO `acceso` VALUES ('70', '1', '2019-04-27 20:38:26');
INSERT INTO `acceso` VALUES ('71', '1', '2019-04-27 20:40:14');
INSERT INTO `acceso` VALUES ('72', '1', '2019-04-27 20:40:55');
INSERT INTO `acceso` VALUES ('73', '1', '2019-04-27 20:41:32');
INSERT INTO `acceso` VALUES ('74', '1', '2019-04-28 20:08:48');
INSERT INTO `acceso` VALUES ('75', '1', '2019-04-28 21:23:07');
INSERT INTO `acceso` VALUES ('76', '1', '2019-04-28 21:25:21');
INSERT INTO `acceso` VALUES ('77', '1', '2019-04-28 21:26:27');
INSERT INTO `acceso` VALUES ('78', '1', '2019-04-28 21:30:04');
INSERT INTO `acceso` VALUES ('79', '1', '2019-04-28 21:33:24');
INSERT INTO `acceso` VALUES ('80', '1', '2019-04-28 21:45:42');
INSERT INTO `acceso` VALUES ('81', '1', '2019-04-28 21:50:02');
INSERT INTO `acceso` VALUES ('82', '1', '2019-04-29 21:11:28');
INSERT INTO `acceso` VALUES ('83', '1', '2019-04-29 21:19:22');
INSERT INTO `acceso` VALUES ('84', '1', '2019-04-30 22:24:01');
INSERT INTO `acceso` VALUES ('85', '1', '2019-04-30 22:47:58');
INSERT INTO `acceso` VALUES ('86', '1', '2019-04-30 22:55:25');
INSERT INTO `acceso` VALUES ('87', '1', '2019-04-30 22:56:48');
INSERT INTO `acceso` VALUES ('88', '1', '2019-04-30 23:01:55');
INSERT INTO `acceso` VALUES ('89', '1', '2019-04-30 23:21:08');
INSERT INTO `acceso` VALUES ('90', '1', '2019-04-30 23:23:27');
INSERT INTO `acceso` VALUES ('91', '1', '2019-04-30 23:46:32');
INSERT INTO `acceso` VALUES ('92', '1', '2019-04-30 23:57:31');
INSERT INTO `acceso` VALUES ('93', '1', '2019-04-30 23:59:48');
INSERT INTO `acceso` VALUES ('94', '1', '2019-05-01 00:06:46');
INSERT INTO `acceso` VALUES ('95', '1', '2019-05-01 00:12:17');
INSERT INTO `acceso` VALUES ('96', '1', '2019-05-01 00:16:24');
INSERT INTO `acceso` VALUES ('97', '1', '2019-05-01 00:18:57');
INSERT INTO `acceso` VALUES ('98', '1', '2019-05-01 00:23:56');
INSERT INTO `acceso` VALUES ('99', '1', '2019-05-01 00:26:52');
INSERT INTO `acceso` VALUES ('100', '1', '2019-05-01 00:41:26');
INSERT INTO `acceso` VALUES ('101', '1', '2019-05-01 00:43:08');
INSERT INTO `acceso` VALUES ('102', '1', '2019-05-01 00:46:55');
INSERT INTO `acceso` VALUES ('103', '1', '2019-05-01 09:33:58');
INSERT INTO `acceso` VALUES ('104', '1', '2019-05-01 09:37:47');
INSERT INTO `acceso` VALUES ('105', '1', '2019-05-01 10:20:04');
INSERT INTO `acceso` VALUES ('106', '1', '2019-05-01 10:25:40');
INSERT INTO `acceso` VALUES ('107', '1', '2019-05-01 10:30:37');
INSERT INTO `acceso` VALUES ('108', '1', '2019-05-01 10:31:33');
INSERT INTO `acceso` VALUES ('109', '1', '2019-05-01 10:32:29');
INSERT INTO `acceso` VALUES ('110', '1', '2019-05-01 10:42:03');
INSERT INTO `acceso` VALUES ('111', '1', '2019-05-01 10:43:12');
INSERT INTO `acceso` VALUES ('112', '1', '2019-05-01 10:44:22');
INSERT INTO `acceso` VALUES ('113', '1', '2019-05-01 10:51:36');
INSERT INTO `acceso` VALUES ('114', '1', '2019-05-01 10:58:55');
INSERT INTO `acceso` VALUES ('115', '1', '2019-05-01 11:09:45');
INSERT INTO `acceso` VALUES ('116', '1', '2019-05-01 11:29:26');
INSERT INTO `acceso` VALUES ('117', '1', '2019-05-01 11:32:28');
INSERT INTO `acceso` VALUES ('118', '1', '2019-05-01 11:38:43');
INSERT INTO `acceso` VALUES ('119', '1', '2019-05-01 12:08:42');
INSERT INTO `acceso` VALUES ('120', '1', '2019-05-01 12:21:38');
INSERT INTO `acceso` VALUES ('121', '1', '2019-05-01 12:26:43');
INSERT INTO `acceso` VALUES ('122', '1', '2019-05-01 12:32:37');
INSERT INTO `acceso` VALUES ('123', '1', '2019-05-01 12:56:05');
INSERT INTO `acceso` VALUES ('124', '1', '2019-05-01 12:58:58');
INSERT INTO `acceso` VALUES ('125', '1', '2019-05-01 15:00:49');
INSERT INTO `acceso` VALUES ('126', '1', '2019-05-01 15:10:07');
INSERT INTO `acceso` VALUES ('127', '1', '2019-05-01 15:34:33');
INSERT INTO `acceso` VALUES ('128', '1', '2019-05-01 16:24:29');
INSERT INTO `acceso` VALUES ('129', '1', '2019-05-01 16:27:10');
INSERT INTO `acceso` VALUES ('130', '1', '2019-05-01 16:28:05');
INSERT INTO `acceso` VALUES ('131', '1', '2019-05-01 16:47:29');
INSERT INTO `acceso` VALUES ('132', '1', '2019-05-01 16:50:27');
INSERT INTO `acceso` VALUES ('133', '1', '2019-05-01 16:58:08');
INSERT INTO `acceso` VALUES ('134', '1', '2019-05-01 17:10:43');
INSERT INTO `acceso` VALUES ('135', '1', '2019-05-01 17:13:31');
INSERT INTO `acceso` VALUES ('136', '1', '2019-05-01 17:15:54');
INSERT INTO `acceso` VALUES ('137', '1', '2019-05-01 17:17:53');
INSERT INTO `acceso` VALUES ('138', '1', '2019-05-01 22:47:10');
INSERT INTO `acceso` VALUES ('139', '1', '2019-05-02 21:27:21');
INSERT INTO `acceso` VALUES ('140', '1', '2019-05-02 21:32:09');
INSERT INTO `acceso` VALUES ('141', '1', '2019-05-02 21:34:32');
INSERT INTO `acceso` VALUES ('142', '1', '2019-05-02 21:40:30');
INSERT INTO `acceso` VALUES ('143', '1', '2019-05-02 21:46:45');
INSERT INTO `acceso` VALUES ('144', '1', '2019-05-02 21:59:06');
INSERT INTO `acceso` VALUES ('145', '1', '2019-05-02 22:03:17');
INSERT INTO `acceso` VALUES ('146', '1', '2019-05-02 22:06:21');
INSERT INTO `acceso` VALUES ('147', '1', '2019-05-02 22:17:37');
INSERT INTO `acceso` VALUES ('148', '1', '2019-05-02 22:19:23');
INSERT INTO `acceso` VALUES ('149', '1', '2019-05-02 22:20:26');
INSERT INTO `acceso` VALUES ('150', '1', '2019-05-02 22:21:13');
INSERT INTO `acceso` VALUES ('151', '1', '2019-05-02 22:23:13');
INSERT INTO `acceso` VALUES ('152', '1', '2019-05-02 22:24:31');
INSERT INTO `acceso` VALUES ('153', '1', '2019-05-02 22:28:25');
INSERT INTO `acceso` VALUES ('154', '1', '2019-05-02 22:31:01');
INSERT INTO `acceso` VALUES ('155', '1', '2019-05-02 22:34:00');
INSERT INTO `acceso` VALUES ('156', '1', '2019-05-02 22:35:25');
INSERT INTO `acceso` VALUES ('157', '1', '2019-05-02 22:37:54');
INSERT INTO `acceso` VALUES ('158', '1', '2019-05-02 22:39:13');
INSERT INTO `acceso` VALUES ('159', '1', '2019-05-02 22:41:40');
INSERT INTO `acceso` VALUES ('160', '1', '2019-05-02 22:43:31');
INSERT INTO `acceso` VALUES ('161', '1', '2019-05-02 22:46:48');
INSERT INTO `acceso` VALUES ('162', '1', '2019-05-02 22:48:23');
INSERT INTO `acceso` VALUES ('163', '1', '2019-05-02 22:49:40');
INSERT INTO `acceso` VALUES ('164', '1', '2019-05-02 22:53:30');
INSERT INTO `acceso` VALUES ('165', '1', '2019-05-02 22:55:14');
INSERT INTO `acceso` VALUES ('166', '1', '2019-05-02 22:56:10');
INSERT INTO `acceso` VALUES ('167', '1', '2019-05-02 22:57:11');
INSERT INTO `acceso` VALUES ('168', '1', '2019-05-02 22:59:52');
INSERT INTO `acceso` VALUES ('169', '1', '2019-05-02 23:01:54');
INSERT INTO `acceso` VALUES ('170', '1', '2019-05-02 23:03:21');
INSERT INTO `acceso` VALUES ('171', '1', '2019-05-02 23:04:04');
INSERT INTO `acceso` VALUES ('172', '1', '2019-05-02 23:05:12');
INSERT INTO `acceso` VALUES ('173', '1', '2019-05-02 23:07:33');
INSERT INTO `acceso` VALUES ('174', '1', '2019-05-02 23:10:00');
INSERT INTO `acceso` VALUES ('175', '1', '2019-05-02 23:14:10');
INSERT INTO `acceso` VALUES ('176', '1', '2019-05-02 23:23:56');
INSERT INTO `acceso` VALUES ('177', '1', '2019-05-02 23:29:16');
INSERT INTO `acceso` VALUES ('178', '1', '2019-05-02 23:32:51');
INSERT INTO `acceso` VALUES ('179', '1', '2019-05-02 23:44:22');
INSERT INTO `acceso` VALUES ('180', '1', '2019-05-03 15:29:42');
INSERT INTO `acceso` VALUES ('181', '1', '2019-05-03 15:36:38');
INSERT INTO `acceso` VALUES ('182', '1', '2019-05-03 15:37:28');
INSERT INTO `acceso` VALUES ('183', '1', '2019-05-03 15:40:00');
INSERT INTO `acceso` VALUES ('184', '1', '2019-05-03 15:41:17');
INSERT INTO `acceso` VALUES ('185', '1', '2019-05-03 15:41:57');
INSERT INTO `acceso` VALUES ('186', '1', '2019-05-03 15:42:39');
INSERT INTO `acceso` VALUES ('187', '1', '2019-05-03 21:02:27');
INSERT INTO `acceso` VALUES ('188', '1', '2019-05-03 21:07:17');
INSERT INTO `acceso` VALUES ('189', '1', '2019-05-03 21:08:00');
INSERT INTO `acceso` VALUES ('190', '1', '2019-05-03 21:11:48');
INSERT INTO `acceso` VALUES ('191', '1', '2019-05-03 21:14:21');
INSERT INTO `acceso` VALUES ('192', '1', '2019-05-03 21:15:39');
INSERT INTO `acceso` VALUES ('193', '1', '2019-05-03 21:21:40');
INSERT INTO `acceso` VALUES ('194', '1', '2019-05-03 21:39:31');
INSERT INTO `acceso` VALUES ('195', '1', '2019-05-04 09:10:26');
INSERT INTO `acceso` VALUES ('196', '1', '2019-05-04 09:22:53');
INSERT INTO `acceso` VALUES ('197', '1', '2019-05-04 09:30:36');
INSERT INTO `acceso` VALUES ('198', '1', '2019-05-05 09:55:39');
INSERT INTO `acceso` VALUES ('199', '1', '2019-05-05 10:19:09');
INSERT INTO `acceso` VALUES ('200', '1', '2019-05-05 10:44:50');
INSERT INTO `acceso` VALUES ('201', '1', '2019-05-05 10:52:01');
INSERT INTO `acceso` VALUES ('202', '1', '2019-05-05 11:18:49');
INSERT INTO `acceso` VALUES ('203', '1', '2019-05-05 11:22:54');
INSERT INTO `acceso` VALUES ('204', '1', '2019-05-05 18:53:28');
INSERT INTO `acceso` VALUES ('205', '1', '2019-05-05 19:02:26');
INSERT INTO `acceso` VALUES ('206', '1', '2019-05-07 21:37:23');
INSERT INTO `acceso` VALUES ('207', '1', '2019-05-07 21:47:20');
INSERT INTO `acceso` VALUES ('208', '1', '2019-05-07 21:59:26');
INSERT INTO `acceso` VALUES ('209', '1', '2019-05-07 22:07:56');
INSERT INTO `acceso` VALUES ('210', '1', '2019-05-07 22:12:30');
INSERT INTO `acceso` VALUES ('211', '1', '2019-05-07 22:34:09');
INSERT INTO `acceso` VALUES ('212', '1', '2019-05-07 22:35:19');
INSERT INTO `acceso` VALUES ('213', '1', '2019-05-07 22:46:32');
INSERT INTO `acceso` VALUES ('214', '1', '2019-05-07 23:16:55');
INSERT INTO `acceso` VALUES ('215', '1', '2019-05-07 23:25:04');
INSERT INTO `acceso` VALUES ('216', '1', '2019-05-07 23:27:36');
INSERT INTO `acceso` VALUES ('217', '1', '2019-05-07 23:31:57');
INSERT INTO `acceso` VALUES ('218', '1', '2019-05-07 23:35:47');
INSERT INTO `acceso` VALUES ('219', '1', '2019-05-08 21:27:58');
INSERT INTO `acceso` VALUES ('220', '1', '2019-05-08 21:37:15');
INSERT INTO `acceso` VALUES ('221', '1', '2019-05-08 22:01:08');
INSERT INTO `acceso` VALUES ('222', '1', '2019-05-09 20:33:46');
INSERT INTO `acceso` VALUES ('223', '1', '2019-05-09 20:52:55');
INSERT INTO `acceso` VALUES ('224', '1', '2019-05-09 21:17:25');
INSERT INTO `acceso` VALUES ('225', '1', '2019-05-09 21:44:39');
INSERT INTO `acceso` VALUES ('226', '1', '2019-05-09 21:51:56');
INSERT INTO `acceso` VALUES ('227', '1', '2019-05-09 22:01:03');
INSERT INTO `acceso` VALUES ('228', '1', '2019-05-09 22:36:30');
INSERT INTO `acceso` VALUES ('229', '1', '2019-05-10 15:37:25');
INSERT INTO `acceso` VALUES ('230', '1', '2019-05-10 15:38:18');
INSERT INTO `acceso` VALUES ('231', '1', '2019-05-10 15:43:02');
INSERT INTO `acceso` VALUES ('232', '1', '2019-05-12 12:31:52');
INSERT INTO `acceso` VALUES ('233', '1', '2019-05-13 14:48:16');
INSERT INTO `acceso` VALUES ('234', '1', '2019-05-13 15:09:44');
INSERT INTO `acceso` VALUES ('235', '1', '2019-05-18 14:28:46');
INSERT INTO `acceso` VALUES ('236', '1', '2019-05-18 14:30:45');
INSERT INTO `acceso` VALUES ('237', '1', '2019-05-18 15:00:59');
INSERT INTO `acceso` VALUES ('238', '1', '2019-05-18 23:05:03');
INSERT INTO `acceso` VALUES ('239', '1', '2019-05-18 23:14:12');
INSERT INTO `acceso` VALUES ('240', '1', '2019-05-18 23:19:44');
INSERT INTO `acceso` VALUES ('241', '1', '2019-05-19 22:52:55');
INSERT INTO `acceso` VALUES ('242', '1', '2019-05-19 22:56:55');
INSERT INTO `acceso` VALUES ('243', '1', '2019-05-19 23:02:12');
INSERT INTO `acceso` VALUES ('244', '1', '2019-05-19 23:21:54');
INSERT INTO `acceso` VALUES ('245', '1', '2019-05-19 23:41:55');
INSERT INTO `acceso` VALUES ('246', '1', '2019-05-19 23:56:30');
INSERT INTO `acceso` VALUES ('247', '1', '2019-05-20 15:03:04');
INSERT INTO `acceso` VALUES ('248', '1', '2019-05-20 15:11:56');
INSERT INTO `acceso` VALUES ('249', '1', '2019-05-21 15:43:38');
INSERT INTO `acceso` VALUES ('250', '1', '2019-05-21 15:54:07');
INSERT INTO `acceso` VALUES ('251', '1', '2019-05-21 21:24:21');
INSERT INTO `acceso` VALUES ('252', '1', '2019-05-21 21:27:13');
INSERT INTO `acceso` VALUES ('253', '1', '2019-05-21 21:29:18');
INSERT INTO `acceso` VALUES ('254', '1', '2019-05-21 21:31:04');
INSERT INTO `acceso` VALUES ('255', '1', '2019-05-21 22:15:54');
INSERT INTO `acceso` VALUES ('256', '1', '2019-05-21 22:42:24');
INSERT INTO `acceso` VALUES ('257', '1', '2019-05-22 14:48:04');
INSERT INTO `acceso` VALUES ('258', '1', '2019-05-22 15:01:55');
INSERT INTO `acceso` VALUES ('259', '1', '2019-05-22 15:21:00');
INSERT INTO `acceso` VALUES ('260', '1', '2019-05-22 15:25:00');
INSERT INTO `acceso` VALUES ('261', '1', '2019-05-22 15:31:56');
INSERT INTO `acceso` VALUES ('262', '1', '2019-05-22 15:38:54');
INSERT INTO `acceso` VALUES ('263', '1', '2019-05-22 15:39:55');
INSERT INTO `acceso` VALUES ('264', '1', '2019-05-22 22:39:20');
INSERT INTO `acceso` VALUES ('265', '1', '2019-05-22 22:46:51');
INSERT INTO `acceso` VALUES ('266', '1', '2019-05-27 20:02:51');
INSERT INTO `acceso` VALUES ('267', '1', '2019-05-27 20:33:30');
INSERT INTO `acceso` VALUES ('268', '1', '2019-05-30 22:55:29');
INSERT INTO `acceso` VALUES ('269', '1', '2019-05-30 23:10:17');
INSERT INTO `acceso` VALUES ('270', '1', '2019-05-30 23:14:42');
INSERT INTO `acceso` VALUES ('271', '1', '2019-05-30 23:27:50');
INSERT INTO `acceso` VALUES ('272', '1', '2019-05-30 23:31:06');
INSERT INTO `acceso` VALUES ('273', '1', '2019-05-30 23:33:42');
INSERT INTO `acceso` VALUES ('274', '1', '2019-05-31 00:03:21');
INSERT INTO `acceso` VALUES ('275', '1', '2019-06-05 14:24:34');
INSERT INTO `acceso` VALUES ('276', '1', '2019-06-05 14:34:39');
INSERT INTO `acceso` VALUES ('277', '1', '2019-06-05 14:52:40');
INSERT INTO `acceso` VALUES ('278', '1', '2019-06-05 15:11:41');
INSERT INTO `acceso` VALUES ('279', '1', '2019-06-05 15:18:09');
INSERT INTO `acceso` VALUES ('280', '1', '2019-06-05 15:21:29');
INSERT INTO `acceso` VALUES ('281', '1', '2019-06-05 15:26:38');
INSERT INTO `acceso` VALUES ('282', '1', '2019-06-05 15:28:28');
INSERT INTO `acceso` VALUES ('283', '1', '2019-06-05 15:34:08');
INSERT INTO `acceso` VALUES ('284', '1', '2019-06-05 21:30:09');
INSERT INTO `acceso` VALUES ('285', '1', '2019-06-05 21:33:12');
INSERT INTO `acceso` VALUES ('286', '1', '2019-06-05 21:34:46');
INSERT INTO `acceso` VALUES ('287', '1', '2019-06-05 21:36:43');
INSERT INTO `acceso` VALUES ('288', '1', '2019-06-05 21:55:40');
INSERT INTO `acceso` VALUES ('289', '1', '2019-06-05 22:01:01');
INSERT INTO `acceso` VALUES ('290', '1', '2019-06-06 14:25:04');
INSERT INTO `acceso` VALUES ('291', '1', '2019-06-06 14:33:31');
INSERT INTO `acceso` VALUES ('292', '1', '2019-06-06 14:37:15');
INSERT INTO `acceso` VALUES ('293', '1', '2019-06-06 14:39:14');
INSERT INTO `acceso` VALUES ('294', '1', '2019-06-07 15:03:20');
INSERT INTO `acceso` VALUES ('295', '1', '2019-06-07 15:04:04');
INSERT INTO `acceso` VALUES ('296', '1', '2019-06-07 15:11:41');
INSERT INTO `acceso` VALUES ('297', '2', '2019-06-07 15:12:39');
INSERT INTO `acceso` VALUES ('298', '2', '2019-06-07 15:13:57');
INSERT INTO `acceso` VALUES ('299', '2', '2019-06-07 15:16:12');
INSERT INTO `acceso` VALUES ('300', '2', '2019-06-07 15:18:11');
INSERT INTO `acceso` VALUES ('301', '2', '2019-06-07 15:18:52');
INSERT INTO `acceso` VALUES ('302', '2', '2019-06-07 15:24:00');
INSERT INTO `acceso` VALUES ('303', '1', '2019-06-07 15:26:02');
INSERT INTO `acceso` VALUES ('304', '1', '2019-06-07 15:26:51');
INSERT INTO `acceso` VALUES ('305', '1', '2019-06-07 15:27:55');
INSERT INTO `acceso` VALUES ('306', '2', '2019-06-07 15:30:35');
INSERT INTO `acceso` VALUES ('307', '1', '2019-06-13 16:33:47');
INSERT INTO `acceso` VALUES ('308', '1', '2019-06-13 19:12:17');
INSERT INTO `acceso` VALUES ('309', '1', '2019-06-13 19:18:39');
INSERT INTO `acceso` VALUES ('310', '1', '2019-06-13 19:20:50');
INSERT INTO `acceso` VALUES ('311', '1', '2019-06-13 19:31:03');
INSERT INTO `acceso` VALUES ('312', '1', '2019-06-13 19:34:05');
INSERT INTO `acceso` VALUES ('313', '1', '2019-06-14 16:02:55');
INSERT INTO `acceso` VALUES ('314', '1', '2019-06-14 16:19:26');
INSERT INTO `acceso` VALUES ('315', '1', '2019-06-14 16:22:26');
INSERT INTO `acceso` VALUES ('316', '1', '2019-06-14 16:24:37');
INSERT INTO `acceso` VALUES ('317', '1', '2019-06-14 16:34:09');
INSERT INTO `acceso` VALUES ('318', '1', '2019-06-14 16:38:07');
INSERT INTO `acceso` VALUES ('319', '1', '2019-06-14 16:39:27');
INSERT INTO `acceso` VALUES ('320', '1', '2019-06-14 17:08:30');
INSERT INTO `acceso` VALUES ('321', '1', '2019-06-14 17:11:26');
INSERT INTO `acceso` VALUES ('322', '1', '2019-06-14 17:13:32');
INSERT INTO `acceso` VALUES ('323', '1', '2019-06-14 17:15:08');
INSERT INTO `acceso` VALUES ('324', '1', '2019-06-14 17:19:21');
INSERT INTO `acceso` VALUES ('325', '1', '2019-06-14 17:21:01');
INSERT INTO `acceso` VALUES ('326', '1', '2019-06-14 17:21:54');
INSERT INTO `acceso` VALUES ('327', '1', '2019-06-14 17:26:38');
INSERT INTO `acceso` VALUES ('328', '1', '2019-06-14 17:28:46');
INSERT INTO `acceso` VALUES ('329', '1', '2019-06-14 17:30:32');
INSERT INTO `acceso` VALUES ('330', '1', '2019-06-14 17:34:46');
INSERT INTO `acceso` VALUES ('331', '1', '2019-06-14 17:35:12');
INSERT INTO `acceso` VALUES ('332', '1', '2019-06-14 17:39:14');
INSERT INTO `acceso` VALUES ('333', '1', '2019-06-14 17:44:09');
INSERT INTO `acceso` VALUES ('334', '1', '2019-06-14 17:45:05');
INSERT INTO `acceso` VALUES ('335', '1', '2019-06-14 17:46:18');
INSERT INTO `acceso` VALUES ('336', '1', '2019-06-14 17:47:57');
INSERT INTO `acceso` VALUES ('337', '1', '2019-06-14 17:49:04');
INSERT INTO `acceso` VALUES ('338', '1', '2019-06-14 17:51:15');
INSERT INTO `acceso` VALUES ('339', '1', '2019-06-14 17:52:01');
INSERT INTO `acceso` VALUES ('340', '1', '2019-06-24 17:25:58');
INSERT INTO `acceso` VALUES ('341', '1', '2019-06-24 18:21:50');
INSERT INTO `acceso` VALUES ('342', '1', '2019-06-25 16:38:00');
INSERT INTO `acceso` VALUES ('343', '1', '2019-06-25 17:12:11');
INSERT INTO `acceso` VALUES ('344', '1', '2019-06-25 17:21:18');
INSERT INTO `acceso` VALUES ('345', '1', '2019-06-25 17:25:46');
INSERT INTO `acceso` VALUES ('346', '1', '2019-06-25 17:29:32');
INSERT INTO `acceso` VALUES ('347', '1', '2019-06-25 17:37:00');
INSERT INTO `acceso` VALUES ('348', '1', '2019-06-25 17:40:27');
INSERT INTO `acceso` VALUES ('349', '1', '2019-06-25 17:45:38');
INSERT INTO `acceso` VALUES ('350', '1', '2019-06-25 17:50:51');
INSERT INTO `acceso` VALUES ('351', '1', '2019-06-25 17:52:10');
INSERT INTO `acceso` VALUES ('352', '1', '2019-06-25 17:55:12');
INSERT INTO `acceso` VALUES ('353', '1', '2019-06-25 17:56:30');
INSERT INTO `acceso` VALUES ('354', '1', '2019-06-26 16:22:05');
INSERT INTO `acceso` VALUES ('355', '1', '2019-06-24 17:09:13');
INSERT INTO `acceso` VALUES ('356', '1', '2019-06-24 17:10:31');
INSERT INTO `acceso` VALUES ('357', '1', '2019-06-24 17:11:12');
INSERT INTO `acceso` VALUES ('358', '1', '2019-06-24 17:13:00');
INSERT INTO `acceso` VALUES ('359', '1', '2019-06-24 17:16:24');
INSERT INTO `acceso` VALUES ('360', '1', '2019-06-24 17:17:23');
INSERT INTO `acceso` VALUES ('361', '1', '2019-06-24 17:17:55');
INSERT INTO `acceso` VALUES ('362', '1', '2019-06-24 17:20:51');
INSERT INTO `acceso` VALUES ('363', '1', '2019-06-24 17:24:29');
INSERT INTO `acceso` VALUES ('364', '1', '2019-06-24 17:26:57');
INSERT INTO `acceso` VALUES ('365', '1', '2019-06-24 17:29:50');
INSERT INTO `acceso` VALUES ('366', '1', '2019-06-24 17:33:32');
INSERT INTO `acceso` VALUES ('367', '1', '2019-06-24 17:45:38');
INSERT INTO `acceso` VALUES ('368', '1', '2019-06-24 17:47:32');
INSERT INTO `acceso` VALUES ('369', '1', '2019-06-27 10:03:44');
INSERT INTO `acceso` VALUES ('370', '1', '2019-06-27 10:04:30');
INSERT INTO `acceso` VALUES ('371', '1', '2019-06-27 10:05:49');
INSERT INTO `acceso` VALUES ('372', '1', '2019-06-27 10:10:15');
INSERT INTO `acceso` VALUES ('373', '1', '2019-06-27 11:26:05');
INSERT INTO `acceso` VALUES ('374', '1', '2019-06-27 11:28:11');
INSERT INTO `acceso` VALUES ('375', '1', '2019-06-28 02:51:24');
INSERT INTO `acceso` VALUES ('376', '1', '2019-06-29 03:00:53');
INSERT INTO `acceso` VALUES ('377', '1', '2019-07-01 03:03:45');
INSERT INTO `acceso` VALUES ('378', '1', '2019-07-01 04:11:59');
INSERT INTO `acceso` VALUES ('379', '1', '2019-07-03 03:50:53');
INSERT INTO `acceso` VALUES ('380', '1', '2019-07-03 09:16:40');
INSERT INTO `acceso` VALUES ('381', '1', '2019-07-03 09:19:58');
INSERT INTO `acceso` VALUES ('382', '1', '2019-07-03 09:29:28');
INSERT INTO `acceso` VALUES ('383', '1', '2019-07-04 03:15:16');
INSERT INTO `acceso` VALUES ('384', '1', '2019-07-04 08:53:05');
INSERT INTO `acceso` VALUES ('385', '1', '2019-07-04 09:30:25');

-- ----------------------------
-- Table structure for almacen
-- ----------------------------
DROP TABLE IF EXISTS `almacen`;
CREATE TABLE `almacen` (
  `idalmacen` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `telefono` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idalmacen`) USING BTREE,
  KEY `frk_idsucursal00` (`idsucursal`) USING BTREE,
  CONSTRAINT `frk_idsucursal00` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of almacen
-- ----------------------------
INSERT INTO `almacen` VALUES ('1', '1', 'ALMACEN CAMAL', '--', '--', '1', '2019-03-29 16:53:43');
INSERT INTO `almacen` VALUES ('2', '2', 'ALMACEN TIENDA I', '--', '--', '1', '2019-04-13 18:14:18');

-- ----------------------------
-- Table structure for auditoria
-- ----------------------------
DROP TABLE IF EXISTS `auditoria`;
CREATE TABLE `auditoria` (
  `idauditoria` int(11) NOT NULL AUTO_INCREMENT,
  `idusuario` int(11) NOT NULL,
  `tabla` varchar(255) NOT NULL,
  `idtabla` int(11) NOT NULL,
  `idoperacion` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idauditoria`) USING BTREE,
  KEY `frk_idusuario02` (`idusuario`) USING BTREE,
  KEY `frk_idoperacion00` (`idoperacion`) USING BTREE,
  CONSTRAINT `frk_idoperacion00` FOREIGN KEY (`idoperacion`) REFERENCES `tipooperacion` (`idtipooperacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idusuario02` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=289 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of auditoria
-- ----------------------------
INSERT INTO `auditoria` VALUES ('1', '1', 'ACCESO', '340', '1', '1', '2019-06-24 17:25:58');
INSERT INTO `auditoria` VALUES ('2', '1', 'PRODUCTO', '1', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `auditoria` VALUES ('3', '1', 'UNIDADEQUIVALENTE', '1', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `auditoria` VALUES ('4', '1', 'PRECIO', '1', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `auditoria` VALUES ('5', '1', 'UNIDADEQUIVALENTE', '2', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `auditoria` VALUES ('6', '1', 'PRECIO', '2', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `auditoria` VALUES ('7', '1', 'PRODUCTO', '2', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `auditoria` VALUES ('8', '1', 'UNIDADEQUIVALENTE', '3', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `auditoria` VALUES ('9', '1', 'PRECIO', '3', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `auditoria` VALUES ('10', '1', 'UNIDADEQUIVALENTE', '4', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `auditoria` VALUES ('11', '1', 'PRECIO', '4', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `auditoria` VALUES ('12', '1', 'PRODUCTO', '3', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `auditoria` VALUES ('13', '1', 'UNIDADEQUIVALENTE', '5', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `auditoria` VALUES ('14', '1', 'PRECIO', '5', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `auditoria` VALUES ('15', '1', 'UNIDADEQUIVALENTE', '6', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `auditoria` VALUES ('16', '1', 'PRECIO', '6', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `auditoria` VALUES ('17', '1', 'PRODUCTO', '4', '1', '1', '2019-06-24 17:36:12');
INSERT INTO `auditoria` VALUES ('18', '1', 'UNIDADEQUIVALENTE', '7', '1', '1', '2019-06-24 17:36:12');
INSERT INTO `auditoria` VALUES ('19', '1', 'PRECIO', '7', '1', '1', '2019-06-24 17:36:12');
INSERT INTO `auditoria` VALUES ('20', '1', 'UNIDADEQUIVALENTE', '8', '1', '1', '2019-06-24 17:36:12');
INSERT INTO `auditoria` VALUES ('21', '1', 'PRECIO', '8', '1', '1', '2019-06-24 17:36:13');
INSERT INTO `auditoria` VALUES ('22', '1', 'PRODUCTO', '5', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `auditoria` VALUES ('23', '1', 'UNIDADEQUIVALENTE', '9', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `auditoria` VALUES ('24', '1', 'PRECIO', '9', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `auditoria` VALUES ('25', '1', 'UNIDADEQUIVALENTE', '10', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `auditoria` VALUES ('26', '1', 'PRECIO', '10', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `auditoria` VALUES ('27', '1', 'PRODUCTO', '6', '1', '1', '2019-06-24 17:38:45');
INSERT INTO `auditoria` VALUES ('28', '1', 'UNIDADEQUIVALENTE', '11', '1', '1', '2019-06-24 17:38:45');
INSERT INTO `auditoria` VALUES ('29', '1', 'PRECIO', '11', '1', '1', '2019-06-24 17:38:45');
INSERT INTO `auditoria` VALUES ('30', '1', 'UNIDADEQUIVALENTE', '12', '1', '1', '2019-06-24 17:38:46');
INSERT INTO `auditoria` VALUES ('31', '1', 'PRECIO', '12', '1', '1', '2019-06-24 17:38:46');
INSERT INTO `auditoria` VALUES ('32', '1', 'PRODUCTO', '7', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `auditoria` VALUES ('33', '1', 'UNIDADEQUIVALENTE', '13', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `auditoria` VALUES ('34', '1', 'PRECIO', '13', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `auditoria` VALUES ('35', '1', 'UNIDADEQUIVALENTE', '14', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `auditoria` VALUES ('36', '1', 'PRECIO', '14', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `auditoria` VALUES ('37', '1', 'PRODUCTO', '8', '1', '1', '2019-06-24 17:39:18');
INSERT INTO `auditoria` VALUES ('38', '1', 'UNIDADEQUIVALENTE', '15', '1', '1', '2019-06-24 17:39:18');
INSERT INTO `auditoria` VALUES ('39', '1', 'PRECIO', '15', '1', '1', '2019-06-24 17:39:18');
INSERT INTO `auditoria` VALUES ('40', '1', 'UNIDADEQUIVALENTE', '16', '1', '1', '2019-06-24 17:39:18');
INSERT INTO `auditoria` VALUES ('41', '1', 'PRECIO', '16', '1', '1', '2019-06-24 17:39:18');
INSERT INTO `auditoria` VALUES ('42', '1', 'ACCESO', '341', '1', '1', '2019-06-24 18:21:50');
INSERT INTO `auditoria` VALUES ('43', '1', 'ACCESO', '342', '1', '1', '2019-06-25 16:38:00');
INSERT INTO `auditoria` VALUES ('44', '1', 'COMPROBANTE', '1', '1', '1', '2019-06-25 16:40:32');
INSERT INTO `auditoria` VALUES ('45', '1', 'DEUDA', '1', '1', '1', '2019-06-25 16:40:32');
INSERT INTO `auditoria` VALUES ('46', '1', 'SERIE', '2', '1', '1', '2019-06-25 16:40:32');
INSERT INTO `auditoria` VALUES ('47', '1', 'DETALLECOMPROBANTE', '1', '1', '1', '2019-06-25 16:40:32');
INSERT INTO `auditoria` VALUES ('48', '1', 'COBRO', '1', '1', '1', '2019-06-25 16:40:40');
INSERT INTO `auditoria` VALUES ('49', '1', 'DEUDA', '1', '2', '1', '2019-06-25 16:40:40');
INSERT INTO `auditoria` VALUES ('50', '1', 'ACCESO', '343', '1', '1', '2019-06-25 17:12:11');
INSERT INTO `auditoria` VALUES ('51', '1', 'COMPROBANTE', '2', '1', '1', '2019-06-25 17:17:56');
INSERT INTO `auditoria` VALUES ('52', '1', 'DEUDA', '1', '2', '1', '2019-06-25 17:17:56');
INSERT INTO `auditoria` VALUES ('53', '1', 'SERIE', '2', '1', '1', '2019-06-25 17:17:56');
INSERT INTO `auditoria` VALUES ('54', '1', 'DETALLECOMPROBANTE', '2', '1', '1', '2019-06-25 17:17:56');
INSERT INTO `auditoria` VALUES ('55', '1', 'DETALLECOMPROBANTE', '3', '1', '1', '2019-06-25 17:17:57');
INSERT INTO `auditoria` VALUES ('56', '1', 'DETALLECOMPROBANTE', '4', '1', '1', '2019-06-25 17:17:57');
INSERT INTO `auditoria` VALUES ('57', '1', 'DETALLECOMPROBANTE', '5', '1', '1', '2019-06-25 17:17:57');
INSERT INTO `auditoria` VALUES ('58', '1', 'DETALLECOMPROBANTE', '6', '1', '1', '2019-06-25 17:17:57');
INSERT INTO `auditoria` VALUES ('59', '1', 'DETALLECOMPROBANTE', '7', '1', '1', '2019-06-25 17:17:57');
INSERT INTO `auditoria` VALUES ('60', '1', 'DETALLECOMPROBANTE', '8', '1', '1', '2019-06-25 17:17:57');
INSERT INTO `auditoria` VALUES ('61', '1', 'ACCESO', '344', '1', '1', '2019-06-25 17:21:18');
INSERT INTO `auditoria` VALUES ('62', '1', 'ACCESO', '345', '1', '1', '2019-06-25 17:25:47');
INSERT INTO `auditoria` VALUES ('63', '1', 'ACCESO', '346', '1', '1', '2019-06-25 17:29:32');
INSERT INTO `auditoria` VALUES ('64', '1', 'ACCESO', '347', '1', '1', '2019-06-25 17:37:00');
INSERT INTO `auditoria` VALUES ('65', '1', 'ACCESO', '348', '1', '1', '2019-06-25 17:40:27');
INSERT INTO `auditoria` VALUES ('66', '1', 'ACCESO', '349', '1', '1', '2019-06-25 17:45:38');
INSERT INTO `auditoria` VALUES ('67', '1', 'ACCESO', '350', '1', '1', '2019-06-25 17:50:52');
INSERT INTO `auditoria` VALUES ('68', '1', 'ACCESO', '351', '1', '1', '2019-06-25 17:52:10');
INSERT INTO `auditoria` VALUES ('69', '1', 'ACCESO', '352', '1', '1', '2019-06-25 17:55:12');
INSERT INTO `auditoria` VALUES ('70', '1', 'ACCESO', '353', '1', '1', '2019-06-25 17:56:30');
INSERT INTO `auditoria` VALUES ('71', '1', 'ACCESO', '354', '1', '1', '2019-06-26 16:22:05');
INSERT INTO `auditoria` VALUES ('72', '1', 'CLIENTE', '4', '1', '1', '2019-06-26 16:25:54');
INSERT INTO `auditoria` VALUES ('73', '1', 'COMPROBANTE', '3', '1', '1', '2019-06-26 16:26:02');
INSERT INTO `auditoria` VALUES ('74', '1', 'DEUDA', '2', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('75', '1', 'SERIE', '2', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('76', '1', 'DETALLECOMPROBANTE', '9', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('77', '1', 'DETALLECOMPROBANTE', '10', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('78', '1', 'DETALLECOMPROBANTE', '11', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('79', '1', 'DETALLECOMPROBANTE', '12', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('80', '1', 'DETALLECOMPROBANTE', '13', '1', '1', '2019-06-26 16:26:03');
INSERT INTO `auditoria` VALUES ('81', '1', 'COBRO', '2', '1', '1', '2019-06-26 16:27:15');
INSERT INTO `auditoria` VALUES ('82', '1', 'DEUDA', '2', '2', '1', '2019-06-26 16:27:15');
INSERT INTO `auditoria` VALUES ('83', '1', 'COMPROBANTE', '4', '1', '1', '2019-06-26 16:28:24');
INSERT INTO `auditoria` VALUES ('84', '1', 'DEUDA', '2', '2', '1', '2019-06-26 16:28:24');
INSERT INTO `auditoria` VALUES ('85', '1', 'SERIE', '1', '1', '1', '2019-06-26 16:28:24');
INSERT INTO `auditoria` VALUES ('86', '1', 'DETALLECOMPROBANTE', '14', '1', '1', '2019-06-26 16:28:24');
INSERT INTO `auditoria` VALUES ('87', '1', 'COMPROBANTE', '5', '1', '1', '2019-06-27 16:32:03');
INSERT INTO `auditoria` VALUES ('88', '1', 'DEUDA', '1', '2', '1', '2019-06-27 16:32:03');
INSERT INTO `auditoria` VALUES ('89', '1', 'SERIE', '2', '1', '1', '2019-06-27 16:32:03');
INSERT INTO `auditoria` VALUES ('90', '1', 'DETALLECOMPROBANTE', '15', '1', '1', '2019-06-27 16:32:03');
INSERT INTO `auditoria` VALUES ('91', '1', 'DETALLECOMPROBANTE', '16', '1', '1', '2019-06-27 16:32:03');
INSERT INTO `auditoria` VALUES ('92', '1', 'DETALLECOMPROBANTE', '17', '1', '1', '2019-06-27 16:32:03');
INSERT INTO `auditoria` VALUES ('93', '1', 'COMPROBANTE', '6', '1', '1', '2019-06-24 16:45:52');
INSERT INTO `auditoria` VALUES ('94', '1', 'DEUDA', '1', '2', '1', '2019-06-24 16:45:52');
INSERT INTO `auditoria` VALUES ('95', '1', 'SERIE', '2', '1', '1', '2019-06-24 16:45:52');
INSERT INTO `auditoria` VALUES ('96', '1', 'DETALLECOMPROBANTE', '18', '1', '1', '2019-06-24 16:45:52');
INSERT INTO `auditoria` VALUES ('97', '1', 'DETALLECOMPROBANTE', '19', '1', '1', '2019-06-24 16:45:52');
INSERT INTO `auditoria` VALUES ('98', '1', 'ACCESO', '355', '1', '1', '2019-06-24 17:09:13');
INSERT INTO `auditoria` VALUES ('99', '1', 'ACCESO', '356', '1', '1', '2019-06-24 17:10:31');
INSERT INTO `auditoria` VALUES ('100', '1', 'ACCESO', '357', '1', '1', '2019-06-24 17:11:12');
INSERT INTO `auditoria` VALUES ('101', '1', 'ACCESO', '358', '1', '1', '2019-06-24 17:13:00');
INSERT INTO `auditoria` VALUES ('102', '1', 'ACCESO', '359', '1', '1', '2019-06-24 17:16:24');
INSERT INTO `auditoria` VALUES ('103', '1', 'ACCESO', '360', '1', '1', '2019-06-24 17:17:23');
INSERT INTO `auditoria` VALUES ('104', '1', 'ACCESO', '361', '1', '1', '2019-06-24 17:17:55');
INSERT INTO `auditoria` VALUES ('105', '1', 'ACCESO', '362', '1', '1', '2019-06-24 17:20:51');
INSERT INTO `auditoria` VALUES ('106', '1', 'ACCESO', '363', '1', '1', '2019-06-24 17:24:29');
INSERT INTO `auditoria` VALUES ('107', '1', 'ACCESO', '364', '1', '1', '2019-06-24 17:26:57');
INSERT INTO `auditoria` VALUES ('108', '1', 'ACCESO', '365', '1', '1', '2019-06-24 17:29:50');
INSERT INTO `auditoria` VALUES ('109', '1', 'ACCESO', '366', '1', '1', '2019-06-24 17:33:32');
INSERT INTO `auditoria` VALUES ('110', '1', 'COMPROBANTE', '7', '1', '1', '2019-06-24 17:37:15');
INSERT INTO `auditoria` VALUES ('111', '1', 'DEUDA', '3', '1', '1', '2019-06-24 17:37:15');
INSERT INTO `auditoria` VALUES ('112', '1', 'SERIE', '2', '1', '1', '2019-06-24 17:37:15');
INSERT INTO `auditoria` VALUES ('113', '1', 'DETALLECOMPROBANTE', '20', '1', '1', '2019-06-24 17:37:24');
INSERT INTO `auditoria` VALUES ('114', '1', 'COMPROBANTE', '8', '1', '1', '2019-06-24 17:41:02');
INSERT INTO `auditoria` VALUES ('115', '1', 'DEUDA', '1', '2', '1', '2019-06-24 17:41:02');
INSERT INTO `auditoria` VALUES ('116', '1', 'SERIE', '2', '1', '1', '2019-06-24 17:41:02');
INSERT INTO `auditoria` VALUES ('117', '1', 'DETALLECOMPROBANTE', '21', '1', '1', '2019-06-24 17:41:02');
INSERT INTO `auditoria` VALUES ('118', '1', 'ACCESO', '367', '1', '1', '2019-06-24 17:45:38');
INSERT INTO `auditoria` VALUES ('119', '1', 'ACCESO', '368', '1', '1', '2019-06-24 17:47:32');
INSERT INTO `auditoria` VALUES ('120', '1', 'COMPROBANTE', '9', '1', '1', '2019-06-26 17:49:35');
INSERT INTO `auditoria` VALUES ('121', '1', 'DEUDA', '3', '2', '1', '2019-06-26 17:49:35');
INSERT INTO `auditoria` VALUES ('122', '1', 'SERIE', '2', '1', '1', '2019-06-26 17:49:35');
INSERT INTO `auditoria` VALUES ('123', '1', 'DETALLECOMPROBANTE', '22', '1', '1', '2019-06-26 17:49:35');
INSERT INTO `auditoria` VALUES ('124', '1', 'DETALLECOMPROBANTE', '23', '1', '1', '2019-06-26 17:49:35');
INSERT INTO `auditoria` VALUES ('125', '1', 'DETALLECOMPROBANTE', '24', '1', '1', '2019-06-26 17:49:35');
INSERT INTO `auditoria` VALUES ('126', '1', 'ACCESO', '369', '1', '1', '2019-06-27 10:03:44');
INSERT INTO `auditoria` VALUES ('127', '1', 'ACCESO', '370', '1', '1', '2019-06-27 10:04:31');
INSERT INTO `auditoria` VALUES ('128', '1', 'ACCESO', '371', '1', '1', '2019-06-27 10:05:49');
INSERT INTO `auditoria` VALUES ('129', '1', 'ACCESO', '372', '1', '1', '2019-06-27 10:10:15');
INSERT INTO `auditoria` VALUES ('130', '1', 'ACCESO', '373', '1', '1', '2019-06-27 11:26:05');
INSERT INTO `auditoria` VALUES ('131', '1', 'ACCESO', '374', '1', '1', '2019-06-27 11:28:11');
INSERT INTO `auditoria` VALUES ('132', '1', 'ACCESO', '375', '1', '1', '2019-06-28 02:51:24');
INSERT INTO `auditoria` VALUES ('133', '1', 'CLIENTE', '5', '1', '1', '2019-06-28 02:52:05');
INSERT INTO `auditoria` VALUES ('134', '1', 'CLIENTE', '6', '1', '1', '2019-06-28 02:52:41');
INSERT INTO `auditoria` VALUES ('135', '1', 'CLIENTE', '7', '1', '1', '2019-06-28 02:52:59');
INSERT INTO `auditoria` VALUES ('136', '1', 'COMPROBANTE', '10', '1', '1', '2019-06-28 02:56:42');
INSERT INTO `auditoria` VALUES ('137', '1', 'DEUDA', '1', '2', '1', '2019-06-28 02:56:42');
INSERT INTO `auditoria` VALUES ('138', '1', 'SERIE', '2', '1', '1', '2019-06-28 02:56:42');
INSERT INTO `auditoria` VALUES ('139', '1', 'DETALLECOMPROBANTE', '25', '1', '1', '2019-06-28 02:56:42');
INSERT INTO `auditoria` VALUES ('140', '1', 'COMPROBANTE', '11', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('141', '1', 'DEUDA', '4', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('142', '1', 'SERIE', '2', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('143', '1', 'DETALLECOMPROBANTE', '26', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('144', '1', 'DETALLECOMPROBANTE', '27', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('145', '1', 'DETALLECOMPROBANTE', '28', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('146', '1', 'DETALLECOMPROBANTE', '29', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('147', '1', 'DETALLECOMPROBANTE', '30', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('148', '1', 'DETALLECOMPROBANTE', '31', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('149', '1', 'DETALLECOMPROBANTE', '32', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('150', '1', 'DETALLECOMPROBANTE', '33', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('151', '1', 'DETALLECOMPROBANTE', '34', '1', '1', '2019-06-28 03:35:57');
INSERT INTO `auditoria` VALUES ('152', '1', 'COMPROBANTE', '11', '2', '1', '2019-06-28 03:54:34');
INSERT INTO `auditoria` VALUES ('153', '1', 'DEUDA', '4', '2', '1', '2019-06-28 03:54:34');
INSERT INTO `auditoria` VALUES ('154', '1', 'COMPROBANTE', '12', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('155', '1', 'DEUDA', '1', '2', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('156', '1', 'SERIE', '2', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('157', '1', 'DETALLECOMPROBANTE', '35', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('158', '1', 'DETALLECOMPROBANTE', '36', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('159', '1', 'DETALLECOMPROBANTE', '37', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('160', '1', 'DETALLECOMPROBANTE', '38', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('161', '1', 'DETALLECOMPROBANTE', '39', '1', '1', '2019-06-28 04:05:04');
INSERT INTO `auditoria` VALUES ('162', '1', 'DETALLECOMPROBANTE', '40', '1', '1', '2019-06-28 04:05:05');
INSERT INTO `auditoria` VALUES ('163', '1', 'DETALLECOMPROBANTE', '41', '1', '1', '2019-06-28 04:05:05');
INSERT INTO `auditoria` VALUES ('164', '1', 'DETALLECOMPROBANTE', '42', '1', '1', '2019-06-28 04:05:05');
INSERT INTO `auditoria` VALUES ('165', '1', 'DETALLECOMPROBANTE', '43', '1', '1', '2019-06-28 04:05:05');
INSERT INTO `auditoria` VALUES ('166', '1', 'COBRO', '3', '1', '1', '2019-06-28 04:13:05');
INSERT INTO `auditoria` VALUES ('167', '1', 'DEUDA', '1', '2', '1', '2019-06-28 04:13:05');
INSERT INTO `auditoria` VALUES ('168', '1', 'ACCESO', '376', '1', '1', '2019-06-29 03:00:53');
INSERT INTO `auditoria` VALUES ('169', '1', 'COMPROBANTE', '13', '1', '1', '2019-06-29 03:02:09');
INSERT INTO `auditoria` VALUES ('170', '1', 'DEUDA', '1', '2', '1', '2019-06-29 03:02:09');
INSERT INTO `auditoria` VALUES ('171', '1', 'SERIE', '2', '1', '1', '2019-06-29 03:02:09');
INSERT INTO `auditoria` VALUES ('172', '1', 'DETALLECOMPROBANTE', '44', '1', '1', '2019-06-29 03:02:09');
INSERT INTO `auditoria` VALUES ('173', '1', 'ACCESO', '377', '1', '1', '2019-07-01 03:03:45');
INSERT INTO `auditoria` VALUES ('174', '1', 'COBRO', '4', '1', '1', '2019-07-01 03:06:08');
INSERT INTO `auditoria` VALUES ('175', '1', 'DEUDA', '1', '2', '1', '2019-07-01 03:06:08');
INSERT INTO `auditoria` VALUES ('176', '1', 'ACCESO', '378', '1', '1', '2019-07-01 04:11:59');
INSERT INTO `auditoria` VALUES ('177', '1', 'COMPROBANTE', '14', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('178', '1', 'DEUDA', '4', '2', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('179', '1', 'SERIE', '2', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('180', '1', 'DETALLECOMPROBANTE', '45', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('181', '1', 'DETALLECOMPROBANTE', '46', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('182', '1', 'DETALLECOMPROBANTE', '47', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('183', '1', 'DETALLECOMPROBANTE', '48', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('184', '1', 'DETALLECOMPROBANTE', '49', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('185', '1', 'DETALLECOMPROBANTE', '50', '1', '1', '2019-07-01 04:18:42');
INSERT INTO `auditoria` VALUES ('186', '1', 'COMPROBANTE', '15', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('187', '1', 'DEUDA', '5', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('188', '1', 'SERIE', '2', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('189', '1', 'DETALLECOMPROBANTE', '51', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('190', '1', 'DETALLECOMPROBANTE', '52', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('191', '1', 'DETALLECOMPROBANTE', '53', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('192', '1', 'DETALLECOMPROBANTE', '54', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('193', '1', 'DETALLECOMPROBANTE', '55', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('194', '1', 'DETALLECOMPROBANTE', '56', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('195', '1', 'DETALLECOMPROBANTE', '57', '1', '1', '2019-07-01 05:13:06');
INSERT INTO `auditoria` VALUES ('196', '1', 'ACCESO', '379', '1', '1', '2019-07-03 03:50:53');
INSERT INTO `auditoria` VALUES ('197', '1', 'COMPROBANTE', '16', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('198', '1', 'DEUDA', '4', '2', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('199', '1', 'SERIE', '2', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('200', '1', 'DETALLECOMPROBANTE', '58', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('201', '1', 'DETALLECOMPROBANTE', '59', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('202', '1', 'DETALLECOMPROBANTE', '60', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('203', '1', 'DETALLECOMPROBANTE', '61', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('204', '1', 'DETALLECOMPROBANTE', '62', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('205', '1', 'DETALLECOMPROBANTE', '63', '1', '1', '2019-07-03 03:54:51');
INSERT INTO `auditoria` VALUES ('206', '1', 'COBRO', '5', '1', '1', '2019-07-03 03:56:46');
INSERT INTO `auditoria` VALUES ('207', '1', 'DEUDA', '4', '2', '1', '2019-07-03 03:56:46');
INSERT INTO `auditoria` VALUES ('208', '1', 'COMPROBANTE', '14', '2', '1', '2019-07-03 03:59:38');
INSERT INTO `auditoria` VALUES ('209', '1', 'DEUDA', '4', '2', '1', '2019-07-03 03:59:38');
INSERT INTO `auditoria` VALUES ('210', '1', 'COMPROBANTE', '16', '2', '1', '2019-07-03 04:03:47');
INSERT INTO `auditoria` VALUES ('211', '1', 'DEUDA', '4', '2', '1', '2019-07-03 04:03:47');
INSERT INTO `auditoria` VALUES ('212', '1', 'CLIENTE', '8', '1', '1', '2019-07-03 04:33:40');
INSERT INTO `auditoria` VALUES ('213', '1', 'CLIENTE', '9', '1', '1', '2019-07-03 04:37:21');
INSERT INTO `auditoria` VALUES ('214', '1', 'COMPROBANTE', '17', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('215', '1', 'DEUDA', '6', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('216', '1', 'SERIE', '2', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('217', '1', 'DETALLECOMPROBANTE', '64', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('218', '1', 'DETALLECOMPROBANTE', '65', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('219', '1', 'DETALLECOMPROBANTE', '66', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('220', '1', 'DETALLECOMPROBANTE', '67', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('221', '1', 'DETALLECOMPROBANTE', '68', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('222', '1', 'DETALLECOMPROBANTE', '69', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('223', '1', 'DETALLECOMPROBANTE', '70', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('224', '1', 'DETALLECOMPROBANTE', '71', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('225', '1', 'DETALLECOMPROBANTE', '72', '1', '1', '2019-07-03 05:41:29');
INSERT INTO `auditoria` VALUES ('226', '1', 'CLIENTE', '10', '1', '1', '2019-07-03 05:58:10');
INSERT INTO `auditoria` VALUES ('227', '1', 'ACCESO', '380', '1', '1', '2019-07-03 09:16:40');
INSERT INTO `auditoria` VALUES ('228', '1', 'ACCESO', '381', '1', '1', '2019-07-03 09:19:58');
INSERT INTO `auditoria` VALUES ('229', '1', 'ACCESO', '382', '1', '1', '2019-07-03 09:29:28');
INSERT INTO `auditoria` VALUES ('230', '1', 'COMPROBANTE', '18', '1', '1', '2019-07-03 09:31:17');
INSERT INTO `auditoria` VALUES ('231', '1', 'DEUDA', '4', '2', '1', '2019-07-03 09:31:18');
INSERT INTO `auditoria` VALUES ('232', '1', 'SERIE', '2', '1', '1', '2019-07-03 09:31:18');
INSERT INTO `auditoria` VALUES ('233', '1', 'DETALLECOMPROBANTE', '73', '1', '1', '2019-07-03 09:31:18');
INSERT INTO `auditoria` VALUES ('234', '1', 'ACCESO', '383', '1', '1', '2019-07-04 03:15:16');
INSERT INTO `auditoria` VALUES ('235', '1', 'COMPROBANTE', '18', '2', '1', '2019-07-04 03:16:06');
INSERT INTO `auditoria` VALUES ('236', '1', 'DEUDA', '4', '2', '1', '2019-07-04 03:16:06');
INSERT INTO `auditoria` VALUES ('237', '1', 'COMPROBANTE', '15', '2', '1', '2019-07-04 03:17:14');
INSERT INTO `auditoria` VALUES ('238', '1', 'DEUDA', '5', '2', '1', '2019-07-04 03:17:14');
INSERT INTO `auditoria` VALUES ('239', '1', 'COMPROBANTE', '17', '2', '1', '2019-07-04 03:18:10');
INSERT INTO `auditoria` VALUES ('240', '1', 'DEUDA', '6', '2', '1', '2019-07-04 03:18:10');
INSERT INTO `auditoria` VALUES ('241', '1', 'CLIENTE', '11', '1', '1', '2019-07-04 03:18:53');
INSERT INTO `auditoria` VALUES ('242', '1', 'CLIENTE', '12', '1', '1', '2019-07-04 03:19:08');
INSERT INTO `auditoria` VALUES ('243', '1', 'CLIENTE', '13', '1', '1', '2019-07-04 03:20:52');
INSERT INTO `auditoria` VALUES ('244', '1', 'CLIENTE', '14', '1', '1', '2019-07-04 03:21:19');
INSERT INTO `auditoria` VALUES ('245', '1', 'COMPROBANTE', '19', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('246', '1', 'DEUDA', '4', '2', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('247', '1', 'SERIE', '2', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('248', '1', 'DETALLECOMPROBANTE', '74', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('249', '1', 'DETALLECOMPROBANTE', '75', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('250', '1', 'DETALLECOMPROBANTE', '76', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('251', '1', 'DETALLECOMPROBANTE', '77', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('252', '1', 'DETALLECOMPROBANTE', '78', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('253', '1', 'DETALLECOMPROBANTE', '79', '1', '1', '2019-07-04 04:01:32');
INSERT INTO `auditoria` VALUES ('254', '1', 'COBRO', '1', '2', '1', '2019-07-04 04:06:39');
INSERT INTO `auditoria` VALUES ('255', '1', 'COBRO', '4', '2', '1', '2019-07-04 04:07:51');
INSERT INTO `auditoria` VALUES ('256', '1', 'COBRO', '5', '2', '1', '2019-07-04 04:08:28');
INSERT INTO `auditoria` VALUES ('257', '1', 'COBRO', '2', '2', '1', '2019-07-04 04:09:07');
INSERT INTO `auditoria` VALUES ('258', '1', 'COBRO', '3', '2', '1', '2019-07-04 04:10:08');
INSERT INTO `auditoria` VALUES ('259', '1', 'CLIENTE', '15', '1', '1', '2019-07-04 04:24:09');
INSERT INTO `auditoria` VALUES ('260', '1', 'COMPROBANTE', '20', '1', '1', '2019-07-04 04:25:14');
INSERT INTO `auditoria` VALUES ('261', '1', 'DEUDA', '7', '1', '1', '2019-07-04 04:25:14');
INSERT INTO `auditoria` VALUES ('262', '1', 'SERIE', '2', '1', '1', '2019-07-04 04:25:14');
INSERT INTO `auditoria` VALUES ('263', '1', 'DETALLECOMPROBANTE', '80', '1', '1', '2019-07-04 04:25:14');
INSERT INTO `auditoria` VALUES ('264', '1', 'COMPROBANTE', '21', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('265', '1', 'DEUDA', '8', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('266', '1', 'SERIE', '2', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('267', '1', 'DETALLECOMPROBANTE', '81', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('268', '1', 'DETALLECOMPROBANTE', '82', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('269', '1', 'DETALLECOMPROBANTE', '83', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('270', '1', 'DETALLECOMPROBANTE', '84', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('271', '1', 'DETALLECOMPROBANTE', '85', '1', '1', '2019-07-04 05:44:22');
INSERT INTO `auditoria` VALUES ('272', '1', 'COMPROBANTE', '22', '1', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('273', '1', 'DEUDA', '5', '2', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('274', '1', 'SERIE', '2', '1', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('275', '1', 'DETALLECOMPROBANTE', '86', '1', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('276', '1', 'DETALLECOMPROBANTE', '87', '1', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('277', '1', 'DETALLECOMPROBANTE', '88', '1', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('278', '1', 'DETALLECOMPROBANTE', '89', '1', '1', '2019-07-04 05:53:33');
INSERT INTO `auditoria` VALUES ('279', '1', 'ACCESO', '384', '1', '1', '2019-07-04 08:53:05');
INSERT INTO `auditoria` VALUES ('280', '1', 'ACCESO', '385', '1', '1', '2019-07-04 09:30:25');
INSERT INTO `auditoria` VALUES ('281', '1', 'PRODUCTO', '3', '2', '1', '2019-07-04 09:31:00');
INSERT INTO `auditoria` VALUES ('282', '1', 'UNIDADEQUIVALENTE', '5', '2', '1', '2019-07-04 09:31:00');
INSERT INTO `auditoria` VALUES ('283', '1', 'UNIDADEQUIVALENTE', '6', '2', '1', '2019-07-04 09:31:00');
INSERT INTO `auditoria` VALUES ('284', '1', 'PRECIO', '6', '2', '1', '2019-07-04 09:31:00');
INSERT INTO `auditoria` VALUES ('285', '1', 'PRODUCTO', '4', '2', '1', '2019-07-04 09:31:09');
INSERT INTO `auditoria` VALUES ('286', '1', 'UNIDADEQUIVALENTE', '7', '2', '1', '2019-07-04 09:31:09');
INSERT INTO `auditoria` VALUES ('287', '1', 'UNIDADEQUIVALENTE', '8', '2', '1', '2019-07-04 09:31:09');
INSERT INTO `auditoria` VALUES ('288', '1', 'PRECIO', '8', '2', '1', '2019-07-04 09:31:09');

-- ----------------------------
-- Table structure for banco
-- ----------------------------
DROP TABLE IF EXISTS `banco`;
CREATE TABLE `banco` (
  `idbanco` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`idbanco`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of banco
-- ----------------------------

-- ----------------------------
-- Table structure for caja
-- ----------------------------
DROP TABLE IF EXISTS `caja`;
CREATE TABLE `caja` (
  `idcaja` int(11) NOT NULL AUTO_INCREMENT,
  `idtipocaja` int(11) NOT NULL,
  `fechaapertura` date NOT NULL,
  `idserie` int(11) NOT NULL,
  `nserie` varchar(255) NOT NULL,
  `ncorrelativo` varchar(255) NOT NULL,
  `ncaja` varchar(255) NOT NULL,
  `montoapertura` decimal(20,4) NOT NULL,
  `fechacierre` date DEFAULT NULL,
  `montocierre` decimal(20,4) NOT NULL,
  `totalefectivo` decimal(20,4) NOT NULL,
  `totaldeposito` decimal(20,4) NOT NULL,
  `totaltransferencia` decimal(20,4) NOT NULL,
  `totaltarjeta` decimal(20,4) NOT NULL,
  `totaldisponible` decimal(20,4) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idcaja`) USING BTREE,
  KEY `frk_idtipocaja00` (`idtipocaja`) USING BTREE,
  KEY `frk_idserie03` (`idserie`) USING BTREE,
  CONSTRAINT `frk_idtipocaja00` FOREIGN KEY (`idtipocaja`) REFERENCES `tipocaja` (`idtipocaja`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of caja
-- ----------------------------

-- ----------------------------
-- Table structure for categoria
-- ----------------------------
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE `categoria` (
  `idcategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idcategoria`) USING BTREE,
  UNIQUE KEY `ind_nombre001` (`nombre`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of categoria
-- ----------------------------
INSERT INTO `categoria` VALUES ('1', 'POLLO VIVO', '1', '2019-04-17 22:33:15');
INSERT INTO `categoria` VALUES ('2', 'POLLO BENEFICIADO', '1', '2019-04-19 15:14:27');
INSERT INTO `categoria` VALUES ('3', 'MENUDENDCIA', '1', '2019-05-03 21:23:34');
INSERT INTO `categoria` VALUES ('4', 'GALLINA', '1', '2019-06-24 16:40:44');

-- ----------------------------
-- Table structure for cliente
-- ----------------------------
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `idcliente` int(11) NOT NULL AUTO_INCREMENT,
  `razonsocial` varchar(255) NOT NULL,
  `idtipodocumento` int(11) NOT NULL,
  `documento` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idcliente`) USING BTREE,
  KEY `frk_idtipodocumento00` (`idtipodocumento`) USING BTREE,
  CONSTRAINT `frk_idtipodocumento00` FOREIGN KEY (`idtipodocumento`) REFERENCES `tipodocumento` (`idtipodocumento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of cliente
-- ----------------------------
INSERT INTO `cliente` VALUES ('1', 'JAVIER TAFUR', '3', '', '', '1', '2019-05-27 20:05:55');
INSERT INTO `cliente` VALUES ('2', 'FABIO REQUENA', '3', '', '', '1', '2019-05-27 20:18:49');
INSERT INTO `cliente` VALUES ('3', 'RAIZA', '3', '', '', '1', '2019-06-05 14:38:23');
INSERT INTO `cliente` VALUES ('4', 'ERWIN TORRES', '3', '47961796', '', '1', '2019-06-26 16:25:54');
INSERT INTO `cliente` VALUES ('5', 'CESAR MALDONADO ', '3', '', '', '1', '2019-06-28 02:52:05');
INSERT INTO `cliente` VALUES ('6', 'YOLANDA MARTINEZ', '3', '', '', '1', '2019-06-28 02:52:41');
INSERT INTO `cliente` VALUES ('7', 'HILDA BEJARANO', '3', '', '', '1', '2019-06-28 02:52:59');
INSERT INTO `cliente` VALUES ('8', 'GONZALO HUAMAN', '3', '', '', '1', '2019-07-03 04:33:40');
INSERT INTO `cliente` VALUES ('9', 'GLORIA SEGURA', '3', '', '', '1', '2019-07-03 04:37:21');
INSERT INTO `cliente` VALUES ('10', 'JHONY REUPO', '3', '', '', '1', '2019-07-03 05:58:10');
INSERT INTO `cliente` VALUES ('11', 'SAUL VILCHEZ', '3', '', '', '1', '2019-07-04 03:18:52');
INSERT INTO `cliente` VALUES ('12', 'CELINA', '3', '', '', '1', '2019-07-04 03:19:08');
INSERT INTO `cliente` VALUES ('13', 'MAICOL PAREDES', '3', '', '', '1', '2019-07-04 03:20:51');
INSERT INTO `cliente` VALUES ('14', 'ARTURO ISRRAEL CALUA ROMERO', '3', '', '', '1', '2019-07-04 03:21:19');
INSERT INTO `cliente` VALUES ('15', 'FERNANDO ', '3', '', '', '1', '2019-07-04 04:24:09');

-- ----------------------------
-- Table structure for cobro
-- ----------------------------
DROP TABLE IF EXISTS `cobro`;
CREATE TABLE `cobro` (
  `idcobro` int(11) NOT NULL AUTO_INCREMENT,
  `iddeuda` int(11) NOT NULL,
  `fechacobro` date NOT NULL,
  `idtipocobro` int(11) NOT NULL,
  `idmoneda` int(11) NOT NULL,
  `cuentabancaria` varchar(255) NOT NULL,
  `noperacion` varchar(255) NOT NULL,
  `monto` decimal(20,4) NOT NULL,
  `observacion` varchar(255) DEFAULT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idcobro`) USING BTREE,
  KEY `frk_iddeuda004` (`iddeuda`) USING BTREE,
  KEY `frk_idtipocobro004` (`idtipocobro`) USING BTREE,
  KEY `frk_idmoneda005` (`idmoneda`) USING BTREE,
  CONSTRAINT `frk_iddeuda004` FOREIGN KEY (`iddeuda`) REFERENCES `deuda` (`iddeuda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idmoneda005` FOREIGN KEY (`idmoneda`) REFERENCES `moneda` (`idmoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipocobro004` FOREIGN KEY (`idtipocobro`) REFERENCES `tipocobro` (`idtipocobro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of cobro
-- ----------------------------
INSERT INTO `cobro` VALUES ('1', '1', '2019-06-25', '1', '1', '', '', '38.0000', '', '0', '2019-06-25 16:40:40');
INSERT INTO `cobro` VALUES ('2', '2', '2019-06-26', '1', '1', '', '', '37.8000', '', '0', '2019-06-26 16:27:15');
INSERT INTO `cobro` VALUES ('3', '1', '2019-06-28', '1', '1', '', '', '2530.0000', '', '0', '2019-06-28 04:13:05');
INSERT INTO `cobro` VALUES ('4', '1', '2019-07-01', '1', '1', '', '', '3530.2100', '', '0', '2019-07-01 03:06:08');
INSERT INTO `cobro` VALUES ('5', '4', '2019-07-03', '1', '1', '', '', '1526.4600', '', '0', '2019-07-03 03:56:46');

-- ----------------------------
-- Table structure for comprobante
-- ----------------------------
DROP TABLE IF EXISTS `comprobante`;
CREATE TABLE `comprobante` (
  `idcomprobante` int(11) NOT NULL AUTO_INCREMENT,
  `idserie` int(11) NOT NULL,
  `nserie` varchar(255) NOT NULL,
  `ncorrelativo` varchar(255) NOT NULL,
  `ncomprobante` varchar(255) NOT NULL,
  `fechaemision` date NOT NULL,
  `idtipopago` int(11) NOT NULL,
  `idcliente` int(11) NOT NULL,
  `idmoneda` int(11) NOT NULL,
  `subtotal` decimal(20,4) NOT NULL,
  `igv` decimal(20,4) NOT NULL,
  `total` decimal(20,4) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `idusuario` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  `glosa` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idcomprobante`) USING BTREE,
  KEY `frk_idserie004` (`idserie`) USING BTREE,
  KEY `frk_idtipopago004` (`idtipopago`) USING BTREE,
  KEY `frk_idcliente005` (`idcliente`) USING BTREE,
  KEY `frk_idmoneda055` (`idmoneda`) USING BTREE,
  CONSTRAINT `frk_idcliente005` FOREIGN KEY (`idcliente`) REFERENCES `cliente` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idmoneda055` FOREIGN KEY (`idmoneda`) REFERENCES `moneda` (`idmoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idserie004` FOREIGN KEY (`idserie`) REFERENCES `serie` (`idserie`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipopago004` FOREIGN KEY (`idtipopago`) REFERENCES `tipopago` (`idtipopago`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of comprobante
-- ----------------------------
INSERT INTO `comprobante` VALUES ('1', '2', '0001', '00000001', '0001-00000001', '2019-06-25', '2', '1', '1', '540.6800', '97.3200', '638.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-25 16:40:32', null);
INSERT INTO `comprobante` VALUES ('2', '2', '0001', '00000002', '0001-00000002', '2019-06-25', '2', '1', '1', '1623.2200', '292.1800', '1915.4000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-25 17:17:56', null);
INSERT INTO `comprobante` VALUES ('3', '2', '0001', '00000003', '0001-00000003', '2019-06-26', '2', '4', '1', '1048.9800', '188.8200', '1237.8000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-26 16:26:02', null);
INSERT INTO `comprobante` VALUES ('4', '1', '0001', '00000001', '0001-00000001', '2019-06-25', '2', '4', '1', '423.7300', '76.2700', '500.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-26 16:28:24', null);
INSERT INTO `comprobante` VALUES ('5', '2', '0001', '00000004', '0001-00000004', '2019-06-27', '2', '1', '1', '285.9300', '51.4700', '337.4000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-27 16:32:03', null);
INSERT INTO `comprobante` VALUES ('6', '2', '0001', '00000005', '0001-00000005', '2019-06-24', '2', '1', '1', '254.2400', '45.7600', '300.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-24 16:45:52', null);
INSERT INTO `comprobante` VALUES ('7', '2', '0001', '00000006', '0001-00000006', '2019-06-24', '2', '3', '1', '155.9300', '28.0700', '184.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-24 17:37:15', '');
INSERT INTO `comprobante` VALUES ('8', '2', '0001', '00000007', '0001-00000007', '2019-06-24', '2', '1', '1', '76.2700', '13.7300', '90.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-24 17:41:02', 'sdsdsdsdsd');
INSERT INTO `comprobante` VALUES ('9', '2', '0001', '00000008', '0001-00000008', '2019-06-26', '2', '3', '1', '321.6900', '57.9100', '379.6000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-26 17:49:35', 'DESCRIPCION DE LA VENTA');
INSERT INTO `comprobante` VALUES ('10', '2', '0001', '00000009', '0001-00000009', '2019-06-28', '2', '1', '1', '11.0200', '1.9800', '13.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-28 02:56:42', '');
INSERT INTO `comprobante` VALUES ('11', '2', '0001', '00000010', '0001-00000010', '2019-06-28', '2', '5', '1', '2543.2500', '457.7900', '3001.0400', 'REGISTRO DE COMPROBANTE', '1', '0', '2019-06-28 03:35:57', '');
INSERT INTO `comprobante` VALUES ('12', '2', '0001', '00000011', '0001-00000011', '2019-06-28', '2', '1', '1', '2368.9900', '426.4200', '2795.4100', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-28 04:05:04', '');
INSERT INTO `comprobante` VALUES ('13', '2', '0001', '00000012', '0001-00000012', '2019-06-29', '2', '1', '1', '7.6300', '1.3700', '9.0000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-06-29 03:02:09', '');
INSERT INTO `comprobante` VALUES ('14', '2', '0001', '00000013', '0001-00000013', '2019-07-01', '2', '5', '1', '1293.6100', '232.8500', '1526.4600', 'REGISTRO DE COMPROBANTE', '1', '0', '2019-07-01 04:18:42', '');
INSERT INTO `comprobante` VALUES ('15', '2', '0001', '00000014', '0001-00000014', '2019-07-01', '2', '7', '1', '1682.7100', '302.8900', '1985.6000', 'REGISTRO DE COMPROBANTE', '1', '0', '2019-07-01 05:13:06', '');
INSERT INTO `comprobante` VALUES ('16', '2', '0001', '00000015', '0001-00000015', '2019-07-03', '2', '5', '1', '1323.2500', '238.1900', '1561.4400', 'REGISTRO DE COMPROBANTE', '1', '0', '2019-07-03 03:54:51', '');
INSERT INTO `comprobante` VALUES ('17', '2', '0001', '00000016', '0001-00000016', '2019-07-03', '2', '8', '1', '2194.7300', '395.0500', '2589.7800', 'REGISTRO DE COMPROBANTE', '1', '0', '2019-07-03 05:41:29', '');
INSERT INTO `comprobante` VALUES ('18', '2', '0001', '00000017', '0001-00000017', '2019-07-03', '2', '5', '1', '5957.3100', '1072.3100', '7029.6200', 'REGISTRO DE COMPROBANTE', '1', '0', '2019-07-03 09:31:17', '');
INSERT INTO `comprobante` VALUES ('19', '2', '0001', '00000018', '0001-00000018', '2019-07-04', '2', '5', '1', '1559.3100', '280.6700', '1839.9800', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-07-04 04:01:32', '');
INSERT INTO `comprobante` VALUES ('20', '2', '0001', '00000019', '0001-00000019', '2019-07-04', '2', '15', '1', '48.0500', '8.6500', '56.7000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-07-04 04:25:14', '');
INSERT INTO `comprobante` VALUES ('21', '2', '0001', '00000020', '0001-00000020', '2019-07-04', '2', '9', '1', '1141.9300', '205.5500', '1347.4800', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-07-04 05:44:22', '');
INSERT INTO `comprobante` VALUES ('22', '2', '0001', '00000021', '0001-00000021', '2019-07-04', '2', '7', '1', '1075.6800', '193.6200', '1269.3000', 'REGISTRO DE COMPROBANTE', '1', '1', '2019-07-04 05:53:33', '');

-- ----------------------------
-- Table structure for cuentabancaria
-- ----------------------------
DROP TABLE IF EXISTS `cuentabancaria`;
CREATE TABLE `cuentabancaria` (
  `idcuentabancaria` int(11) NOT NULL AUTO_INCREMENT,
  `idtipocuenta` int(11) NOT NULL,
  `idproveedor` int(11) DEFAULT NULL,
  `idbanco` int(11) NOT NULL,
  `idmoneda` int(11) NOT NULL,
  `numero` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idcuentabancaria`) USING BTREE,
  KEY `frk_idtipocuenta00` (`idtipocuenta`) USING BTREE,
  KEY `frk_idbanco01` (`idbanco`) USING BTREE,
  KEY `frk_idmoneda02` (`idmoneda`) USING BTREE,
  KEY `frk_idproveedor03` (`idproveedor`) USING BTREE,
  CONSTRAINT `frk_idbanco01` FOREIGN KEY (`idbanco`) REFERENCES `banco` (`idbanco`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idmoneda02` FOREIGN KEY (`idmoneda`) REFERENCES `moneda` (`idmoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idproveedor03` FOREIGN KEY (`idproveedor`) REFERENCES `proveedor` (`idproveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipocuenta00` FOREIGN KEY (`idtipocuenta`) REFERENCES `tipocuenta` (`idtipocuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of cuentabancaria
-- ----------------------------

-- ----------------------------
-- Table structure for detallecomprobante
-- ----------------------------
DROP TABLE IF EXISTS `detallecomprobante`;
CREATE TABLE `detallecomprobante` (
  `iddetallecomprobante` int(11) NOT NULL AUTO_INCREMENT,
  `idcomprobante` int(11) NOT NULL,
  `idproducto` int(11) NOT NULL,
  `idunidadequivalente` int(11) NOT NULL,
  `nunidad` decimal(20,4) NOT NULL,
  `pbruto` decimal(20,4) NOT NULL,
  `ptara` decimal(20,4) NOT NULL,
  `pneto` decimal(20,4) NOT NULL,
  `preciounitario` decimal(20,4) NOT NULL,
  `subtotal` decimal(20,4) NOT NULL,
  `igv` decimal(20,4) NOT NULL,
  `total` decimal(20,4) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`iddetallecomprobante`) USING BTREE,
  KEY `frk_idcomprobante00` (`idcomprobante`) USING BTREE,
  KEY `frk_idunidadequivalente01` (`idunidadequivalente`) USING BTREE,
  CONSTRAINT `frk_idcomprobante00` FOREIGN KEY (`idcomprobante`) REFERENCES `comprobante` (`idcomprobante`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idunidadequivalente01` FOREIGN KEY (`idunidadequivalente`) REFERENCES `unidadequivalente` (`idunidadequivalente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of detallecomprobante
-- ----------------------------
INSERT INTO `detallecomprobante` VALUES ('1', '1', '1', '2', '150.0000', '120.0000', '4.0000', '116.0000', '5.5000', '540.6800', '97.3200', '638.0000', '1', '2019-06-25 16:40:32');
INSERT INTO `detallecomprobante` VALUES ('2', '2', '1', '2', '50.0000', '120.0000', '4.0000', '116.0000', '3.5000', '344.0700', '61.9300', '406.0000', '1', '2019-06-25 17:17:56');
INSERT INTO `detallecomprobante` VALUES ('3', '2', '4', '8', '40.0000', '60.0000', '4.0000', '56.0000', '4.5000', '213.5600', '38.4400', '252.0000', '1', '2019-06-25 17:17:56');
INSERT INTO `detallecomprobante` VALUES ('4', '2', '7', '14', '20.0000', '80.0000', '4.0000', '76.0000', '4.2000', '270.5100', '48.6900', '319.2000', '1', '2019-06-25 17:17:57');
INSERT INTO `detallecomprobante` VALUES ('5', '2', '2', '4', '20.0000', '50.0000', '4.0000', '46.0000', '2.0000', '77.9700', '14.0300', '92.0000', '1', '2019-06-25 17:17:57');
INSERT INTO `detallecomprobante` VALUES ('6', '2', '1', '2', '20.0000', '80.0000', '4.0000', '76.0000', '3.5000', '225.4200', '40.5800', '266.0000', '1', '2019-06-25 17:17:57');
INSERT INTO `detallecomprobante` VALUES ('7', '2', '4', '8', '40.0000', '90.0000', '4.0000', '86.0000', '4.5000', '327.9700', '59.0300', '387.0000', '1', '2019-06-25 17:17:57');
INSERT INTO `detallecomprobante` VALUES ('8', '2', '7', '14', '30.0000', '50.0000', '4.0000', '46.0000', '4.2000', '163.7300', '29.4700', '193.2000', '1', '2019-06-25 17:17:57');
INSERT INTO `detallecomprobante` VALUES ('9', '3', '1', '2', '12.0000', '90.0000', '4.0000', '86.0000', '4.5000', '327.9700', '59.0300', '387.0000', '1', '2019-06-26 16:26:03');
INSERT INTO `detallecomprobante` VALUES ('10', '3', '5', '10', '1.0000', '60.0000', '4.0000', '56.0000', '3.2000', '151.8600', '27.3400', '179.2000', '1', '2019-06-26 16:26:03');
INSERT INTO `detallecomprobante` VALUES ('11', '3', '8', '16', '10.0000', '9.0000', '5.0000', '4.0000', '5.0000', '16.9500', '3.0500', '20.0000', '1', '2019-06-26 16:26:03');
INSERT INTO `detallecomprobante` VALUES ('12', '3', '1', '2', '20.0000', '80.0000', '4.0000', '76.0000', '4.5000', '289.8300', '52.1700', '342.0000', '1', '2019-06-26 16:26:03');
INSERT INTO `detallecomprobante` VALUES ('13', '3', '2', '4', '20.0000', '90.0000', '4.0000', '86.0000', '3.6000', '262.3700', '47.2300', '309.6000', '1', '2019-06-26 16:26:03');
INSERT INTO `detallecomprobante` VALUES ('14', '4', '2', '4', '0.0000', '0.0000', '0.0000', '0.0000', '0.0000', '0.0000', '0.0000', '0.0000', '1', '2019-06-26 16:28:24');
INSERT INTO `detallecomprobante` VALUES ('15', '5', '1', '2', '20.0000', '50.0000', '4.0000', '46.0000', '3.5000', '136.4400', '24.5600', '161.0000', '1', '2019-06-27 16:32:03');
INSERT INTO `detallecomprobante` VALUES ('16', '5', '3', '6', '4.0000', '16.0000', '4.0000', '12.0000', '3.2000', '32.5400', '5.8600', '38.4000', '1', '2019-06-27 16:32:03');
INSERT INTO `detallecomprobante` VALUES ('17', '5', '2', '4', '3.0000', '50.0000', '4.0000', '46.0000', '3.0000', '116.9500', '21.0500', '138.0000', '1', '2019-06-27 16:32:03');
INSERT INTO `detallecomprobante` VALUES ('18', '6', '1', '2', '4.5000', '80.0000', '4.0000', '76.0000', '3.0000', '193.2200', '34.7800', '228.0000', '1', '2019-06-24 16:45:52');
INSERT INTO `detallecomprobante` VALUES ('19', '6', '3', '6', '4.0000', '40.0000', '4.0000', '36.0000', '2.0000', '61.0200', '10.9800', '72.0000', '1', '2019-06-24 16:45:52');
INSERT INTO `detallecomprobante` VALUES ('20', '7', '1', '2', '4.0000', '50.0000', '4.0000', '46.0000', '4.0000', '155.9300', '28.0700', '184.0000', '1', '2019-06-24 17:37:24');
INSERT INTO `detallecomprobante` VALUES ('21', '8', '1', '2', '4.0000', '34.0000', '4.0000', '30.0000', '3.0000', '76.2700', '13.7300', '90.0000', '1', '2019-06-24 17:41:02');
INSERT INTO `detallecomprobante` VALUES ('22', '9', '1', '2', '4.0000', '60.0000', '4.0000', '56.0000', '3.5000', '166.1000', '29.9000', '196.0000', '1', '2019-06-26 17:49:35');
INSERT INTO `detallecomprobante` VALUES ('23', '9', '2', '4', '4.0000', '50.0000', '4.0000', '46.0000', '3.6000', '140.3400', '25.2600', '165.6000', '1', '2019-06-26 17:49:35');
INSERT INTO `detallecomprobante` VALUES ('24', '9', '5', '10', '1.0000', '10.0000', '4.0000', '6.0000', '3.0000', '15.2500', '2.7500', '18.0000', '1', '2019-06-26 17:49:35');
INSERT INTO `detallecomprobante` VALUES ('25', '10', '6', '12', '0.0000', '2.0000', '0.0000', '2.0000', '6.5000', '11.0200', '1.9800', '13.0000', '1', '2019-06-28 02:56:42');
INSERT INTO `detallecomprobante` VALUES ('26', '11', '3', '6', '40.0000', '94.8000', '5.9200', '88.8800', '3.9500', '297.5300', '53.5500', '351.0800', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('27', '11', '3', '6', '40.0000', '96.9000', '5.9200', '90.9800', '3.9500', '304.5500', '54.8200', '359.3700', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('28', '11', '3', '6', '40.0000', '94.6000', '5.9200', '88.6800', '3.9500', '296.8600', '53.4300', '350.2900', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('29', '11', '3', '6', '40.0000', '101.1000', '5.9200', '95.1800', '3.9500', '318.6100', '57.3500', '375.9600', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('30', '11', '3', '6', '40.0000', '97.7000', '5.9200', '91.7800', '3.9500', '307.2300', '55.3000', '362.5300', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('31', '11', '3', '6', '40.0000', '96.7000', '5.9200', '90.7800', '3.9500', '303.8800', '54.7000', '358.5800', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('32', '11', '3', '6', '40.0000', '110.3000', '5.9200', '104.3800', '5.9200', '523.6700', '94.2600', '617.9300', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('33', '11', '3', '6', '20.0000', '49.3000', '2.9600', '46.3400', '3.9500', '155.1200', '27.9200', '183.0400', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('34', '11', '6', '12', '0.0000', '10.7000', '0.0000', '10.7000', '3.9500', '35.8100', '6.4500', '42.2600', '0', '2019-06-28 03:35:57');
INSERT INTO `detallecomprobante` VALUES ('35', '12', '3', '6', '40.0000', '94.8000', '5.9200', '88.8800', '3.9500', '297.5300', '53.5500', '351.0800', '1', '2019-06-28 04:05:04');
INSERT INTO `detallecomprobante` VALUES ('36', '12', '3', '6', '40.0000', '96.9000', '5.9200', '90.9800', '3.9500', '304.5500', '54.8200', '359.3700', '1', '2019-06-28 04:05:04');
INSERT INTO `detallecomprobante` VALUES ('37', '12', '3', '6', '40.0000', '94.6000', '5.9200', '88.6800', '3.9500', '296.8600', '53.4300', '350.2900', '1', '2019-06-28 04:05:04');
INSERT INTO `detallecomprobante` VALUES ('38', '12', '3', '6', '40.0000', '101.1000', '5.9200', '95.1800', '3.9500', '318.6100', '57.3500', '375.9600', '1', '2019-06-28 04:05:04');
INSERT INTO `detallecomprobante` VALUES ('39', '12', '3', '6', '40.0000', '97.7000', '5.9200', '91.7800', '3.9500', '307.2300', '55.3000', '362.5300', '1', '2019-06-28 04:05:04');
INSERT INTO `detallecomprobante` VALUES ('40', '12', '3', '6', '40.0000', '96.7000', '5.9200', '90.7800', '3.9500', '303.8800', '54.7000', '358.5800', '1', '2019-06-28 04:05:04');
INSERT INTO `detallecomprobante` VALUES ('41', '12', '3', '6', '40.0000', '110.3000', '5.9200', '104.3800', '3.9500', '349.4100', '62.8900', '412.3000', '1', '2019-06-28 04:05:05');
INSERT INTO `detallecomprobante` VALUES ('42', '12', '3', '6', '20.0000', '49.3000', '2.9600', '46.3400', '3.9500', '155.1200', '27.9200', '183.0400', '1', '2019-06-28 04:05:05');
INSERT INTO `detallecomprobante` VALUES ('43', '12', '6', '12', '0.0000', '10.7000', '0.0000', '10.7000', '3.9500', '35.8100', '6.4500', '42.2600', '1', '2019-06-28 04:05:05');
INSERT INTO `detallecomprobante` VALUES ('44', '13', '6', '12', '0.0000', '1.5000', '0.0000', '1.5000', '6.0000', '7.6300', '1.3700', '9.0000', '1', '2019-06-29 03:02:09');
INSERT INTO `detallecomprobante` VALUES ('45', '14', '3', '6', '40.0000', '83.6000', '5.0000', '78.6000', '3.8000', '253.1200', '45.5600', '298.6800', '0', '2019-07-01 04:18:42');
INSERT INTO `detallecomprobante` VALUES ('46', '14', '3', '6', '40.0000', '83.5000', '5.0000', '78.5000', '3.8000', '252.8000', '45.5000', '298.3000', '0', '2019-07-01 04:18:42');
INSERT INTO `detallecomprobante` VALUES ('47', '14', '3', '6', '40.0000', '84.3000', '5.5000', '78.8000', '3.8000', '253.7600', '45.6800', '299.4400', '0', '2019-07-01 04:18:42');
INSERT INTO `detallecomprobante` VALUES ('48', '14', '3', '6', '40.0000', '84.8000', '5.0000', '79.8000', '3.8000', '256.9800', '46.2600', '303.2400', '0', '2019-07-01 04:18:42');
INSERT INTO `detallecomprobante` VALUES ('49', '14', '3', '6', '40.0000', '82.4000', '5.0000', '77.4000', '3.8000', '249.2500', '44.8700', '294.1200', '0', '2019-07-01 04:18:42');
INSERT INTO `detallecomprobante` VALUES ('50', '14', '6', '12', '0.0000', '8.6000', '0.0000', '8.6000', '3.8000', '27.6900', '4.9900', '32.6800', '0', '2019-07-01 04:18:42');
INSERT INTO `detallecomprobante` VALUES ('51', '15', '1', '2', '45.0000', '138.3000', '40.0000', '98.3000', '3.2000', '266.5800', '47.9800', '314.5600', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('52', '15', '1', '2', '45.0000', '141.0000', '40.0000', '101.0000', '3.2000', '273.9000', '49.3000', '323.2000', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('53', '15', '1', '2', '45.0000', '140.1000', '40.0000', '100.1000', '3.2000', '271.4600', '48.8600', '320.3200', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('54', '15', '1', '2', '45.0000', '135.9000', '40.0000', '95.9000', '3.2000', '260.0700', '46.8100', '306.8800', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('55', '15', '1', '2', '45.0000', '148.4000', '40.0000', '108.4000', '3.2000', '293.9700', '52.9100', '346.8800', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('56', '15', '1', '2', '25.0000', '77.5000', '24.0000', '53.5000', '3.2000', '145.0800', '26.1200', '171.2000', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('57', '15', '1', '2', '27.0000', '87.3000', '24.0000', '63.3000', '3.2000', '171.6600', '30.9000', '202.5600', '0', '2019-07-01 05:13:06');
INSERT INTO `detallecomprobante` VALUES ('58', '16', '3', '6', '40.0000', '87.1000', '5.7800', '81.3200', '3.8000', '261.8800', '47.1400', '309.0200', '0', '2019-07-03 03:54:51');
INSERT INTO `detallecomprobante` VALUES ('59', '16', '3', '6', '40.0000', '86.3000', '5.7800', '80.5200', '3.8000', '259.3100', '46.6700', '305.9800', '0', '2019-07-03 03:54:51');
INSERT INTO `detallecomprobante` VALUES ('60', '16', '3', '6', '40.0000', '85.9000', '5.7800', '80.1200', '3.8000', '258.0200', '46.4400', '304.4600', '0', '2019-07-03 03:54:51');
INSERT INTO `detallecomprobante` VALUES ('61', '16', '3', '6', '40.0000', '87.8000', '5.7800', '82.0200', '3.8000', '264.1400', '47.5400', '311.6800', '0', '2019-07-03 03:54:51');
INSERT INTO `detallecomprobante` VALUES ('62', '16', '3', '6', '40.0000', '85.6000', '5.7800', '79.8200', '3.8000', '257.0500', '46.2700', '303.3200', '0', '2019-07-03 03:54:51');
INSERT INTO `detallecomprobante` VALUES ('63', '16', '6', '12', '0.0000', '7.1000', '0.0000', '7.1000', '3.8000', '22.8600', '4.1200', '26.9800', '0', '2019-07-03 03:54:51');
INSERT INTO `detallecomprobante` VALUES ('64', '17', '1', '2', '40.0000', '138.7000', '40.0000', '98.7000', '3.4000', '284.3900', '51.1900', '335.5800', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('65', '17', '1', '2', '40.0000', '142.4000', '40.0000', '102.4000', '3.4000', '295.0500', '53.1100', '348.1600', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('66', '17', '1', '2', '40.0000', '141.0000', '40.0000', '101.0000', '3.4000', '291.0200', '52.3800', '343.4000', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('67', '17', '1', '2', '40.0000', '141.7000', '40.0000', '101.7000', '3.4000', '293.0300', '52.7500', '345.7800', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('68', '17', '1', '2', '40.0000', '142.3000', '40.0000', '102.3000', '3.4000', '294.7600', '53.0600', '347.8200', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('69', '17', '1', '2', '40.0000', '144.6000', '40.0000', '104.6000', '3.4000', '301.3900', '54.2500', '355.6400', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('70', '17', '1', '2', '40.0000', '144.3000', '40.0000', '104.3000', '3.4000', '300.5300', '54.0900', '354.6200', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('71', '17', '1', '2', '40.0000', '62.7000', '16.0000', '46.7000', '3.4000', '134.5600', '24.2200', '158.7800', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('72', '17', '1', '2', '0.0000', '0.0000', '0.0000', '0.0000', '3.4000', '0.0000', '0.0000', '0.0000', '0', '2019-07-03 05:41:29');
INSERT INTO `detallecomprobante` VALUES ('73', '18', '3', '6', '800.0000', '1952.4000', '102.5000', '1849.9000', '3.8000', '5957.3100', '1072.3100', '7029.6200', '0', '2019-07-03 09:31:18');
INSERT INTO `detallecomprobante` VALUES ('74', '19', '3', '6', '40.0000', '105.1000', '5.6400', '99.4600', '3.6000', '303.4400', '54.6200', '358.0600', '1', '2019-07-04 04:01:32');
INSERT INTO `detallecomprobante` VALUES ('75', '19', '3', '6', '40.0000', '105.4000', '5.6400', '99.7600', '3.6000', '304.3600', '54.7800', '359.1400', '1', '2019-07-04 04:01:32');
INSERT INTO `detallecomprobante` VALUES ('76', '19', '3', '6', '40.0000', '109.5000', '5.6400', '103.8600', '3.6000', '316.8600', '57.0400', '373.9000', '1', '2019-07-04 04:01:32');
INSERT INTO `detallecomprobante` VALUES ('77', '19', '3', '6', '40.0000', '107.3000', '5.6400', '101.6600', '3.6000', '310.1500', '55.8300', '365.9800', '1', '2019-07-04 04:01:32');
INSERT INTO `detallecomprobante` VALUES ('78', '19', '3', '6', '40.0000', '103.7000', '5.6400', '98.0600', '3.6000', '299.1700', '53.8500', '353.0200', '1', '2019-07-04 04:01:32');
INSERT INTO `detallecomprobante` VALUES ('79', '19', '6', '12', '0.0000', '8.3000', '0.0000', '8.3000', '3.6000', '25.3200', '4.5600', '29.8800', '1', '2019-07-04 04:01:32');
INSERT INTO `detallecomprobante` VALUES ('80', '20', '3', '6', '7.0000', '13.5000', '0.0000', '13.5000', '4.2000', '48.0500', '8.6500', '56.7000', '1', '2019-07-04 04:25:14');
INSERT INTO `detallecomprobante` VALUES ('81', '21', '3', '6', '40.0000', '90.7000', '5.7000', '85.0000', '3.8000', '273.7300', '49.2700', '323.0000', '1', '2019-07-04 05:44:22');
INSERT INTO `detallecomprobante` VALUES ('82', '21', '3', '6', '40.0000', '107.2000', '6.0000', '101.2000', '3.8000', '325.9000', '58.6600', '384.5600', '1', '2019-07-04 05:44:22');
INSERT INTO `detallecomprobante` VALUES ('83', '21', '3', '6', '40.0000', '116.5000', '5.7000', '110.8000', '3.8000', '356.8100', '64.2300', '421.0400', '1', '2019-07-04 05:44:22');
INSERT INTO `detallecomprobante` VALUES ('84', '21', '3', '6', '20.0000', '54.9000', '3.0000', '51.9000', '3.8000', '167.1400', '30.0800', '197.2200', '1', '2019-07-04 05:44:22');
INSERT INTO `detallecomprobante` VALUES ('85', '21', '6', '12', '0.0000', '5.7000', '0.0000', '5.7000', '3.8000', '18.3600', '3.3000', '21.6600', '1', '2019-07-04 05:44:22');
INSERT INTO `detallecomprobante` VALUES ('86', '22', '1', '2', '55.0000', '177.4000', '40.0000', '137.4000', '3.0000', '349.3200', '62.8800', '412.2000', '1', '2019-07-04 05:53:33');
INSERT INTO `detallecomprobante` VALUES ('87', '22', '1', '2', '55.0000', '167.9000', '40.0000', '127.9000', '3.0000', '325.1700', '58.5300', '383.7000', '1', '2019-07-04 05:53:33');
INSERT INTO `detallecomprobante` VALUES ('88', '22', '1', '2', '45.0000', '139.7000', '32.0000', '107.7000', '3.0000', '273.8100', '49.2900', '323.1000', '1', '2019-07-04 05:53:33');
INSERT INTO `detallecomprobante` VALUES ('89', '22', '1', '2', '20.0000', '66.1000', '16.0000', '50.1000', '3.0000', '127.3700', '22.9300', '150.3000', '1', '2019-07-04 05:53:33');

-- ----------------------------
-- Table structure for deuda
-- ----------------------------
DROP TABLE IF EXISTS `deuda`;
CREATE TABLE `deuda` (
  `iddeuda` int(11) NOT NULL AUTO_INCREMENT,
  `idcliente` int(11) NOT NULL,
  `montoinicial` decimal(20,4) NOT NULL,
  `montototal` decimal(20,4) NOT NULL,
  `montocobrado` decimal(20,4) NOT NULL,
  `montoactual` decimal(20,4) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`iddeuda`) USING BTREE,
  KEY `frk_idcliente005` (`idcliente`) USING BTREE,
  CONSTRAINT `frk_idcliente004` FOREIGN KEY (`idcliente`) REFERENCES `cliente` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of deuda
-- ----------------------------
INSERT INTO `deuda` VALUES ('1', '1', '0.0000', '6098.2100', '0.0000', '6098.2100', '1', '2019-06-25 16:40:32');
INSERT INTO `deuda` VALUES ('2', '4', '500.0000', '1737.8000', '0.0000', '1737.8000', '1', '2019-06-26 16:26:02');
INSERT INTO `deuda` VALUES ('3', '3', '0.0000', '563.6000', '0.0000', '563.6000', '1', '2019-06-24 17:37:15');
INSERT INTO `deuda` VALUES ('4', '5', '0.0000', '1839.9800', '0.0000', '1839.9800', '1', '2019-06-28 03:35:57');
INSERT INTO `deuda` VALUES ('5', '7', '0.0000', '1269.3000', '0.0000', '1269.3000', '1', '2019-07-01 05:13:06');
INSERT INTO `deuda` VALUES ('6', '8', '0.0000', '0.0000', '0.0000', '0.0000', '1', '2019-07-03 05:41:29');
INSERT INTO `deuda` VALUES ('7', '15', '0.0000', '56.7000', '0.0000', '56.7000', '1', '2019-07-04 04:25:14');
INSERT INTO `deuda` VALUES ('8', '9', '0.0000', '1347.4800', '0.0000', '1347.4800', '1', '2019-07-04 05:44:22');

-- ----------------------------
-- Table structure for empresa
-- ----------------------------
DROP TABLE IF EXISTS `empresa`;
CREATE TABLE `empresa` (
  `idempresa` int(11) NOT NULL AUTO_INCREMENT,
  `idtipodocumento` int(11) NOT NULL,
  `razonsocial` varchar(255) NOT NULL,
  `ruc` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `telefono` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idempresa`) USING BTREE,
  UNIQUE KEY `index_ruc00` (`ruc`) USING BTREE,
  KEY `frk_idtipodocumento03` (`idtipodocumento`) USING BTREE,
  CONSTRAINT `frk_idtipodocumento03` FOREIGN KEY (`idtipodocumento`) REFERENCES `tipodocumento` (`idtipodocumento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of empresa
-- ----------------------------
INSERT INTO `empresa` VALUES ('1', '2', 'PROCESADORA AVICOLA NANDO´S', '20561278441', 'HU. SAN BORJA MZ D LT 30  ( AV. AGRICULTURA  KM 5 ) ', '074-236915 / 964518732 / 964513149', '1', '2019-03-26 18:51:56');

-- ----------------------------
-- Table structure for moneda
-- ----------------------------
DROP TABLE IF EXISTS `moneda`;
CREATE TABLE `moneda` (
  `idmoneda` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idmoneda`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of moneda
-- ----------------------------
INSERT INTO `moneda` VALUES ('1', 'SOLES', 'S/', '1', '2019-03-12 08:58:12');
INSERT INTO `moneda` VALUES ('2', 'DOLARES', '$', '0', '2019-03-12 08:58:29');

-- ----------------------------
-- Table structure for movimiento
-- ----------------------------
DROP TABLE IF EXISTS `movimiento`;
CREATE TABLE `movimiento` (
  `idmovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `idtipomovimiento` int(11) NOT NULL,
  `idproductoalmacen` int(11) NOT NULL,
  `fechamovimiento` date NOT NULL,
  `nunidaactual` decimal(20,4) NOT NULL,
  `pesoactual` decimal(20,4) NOT NULL,
  `nunidaingresa` decimal(20,4) NOT NULL,
  `pesoingreso` decimal(20,4) NOT NULL,
  `nunidasalida` decimal(20,4) NOT NULL,
  `pesosalida` decimal(20,4) NOT NULL,
  `nunidafinal` decimal(20,4) NOT NULL,
  `pesofinal` decimal(20,4) NOT NULL,
  `costopromedio` decimal(20,4) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idmovimiento`) USING BTREE,
  KEY `frk_idtipomovimiento00` (`idtipomovimiento`) USING BTREE,
  KEY `frk_idproductoalmacen02` (`idproductoalmacen`) USING BTREE,
  CONSTRAINT `frk_idproductoalmacen02` FOREIGN KEY (`idproductoalmacen`) REFERENCES `productoalmacen` (`idproductoalmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipomovimiento00` FOREIGN KEY (`idtipomovimiento`) REFERENCES `tipomovimiento` (`idtipomovimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of movimiento
-- ----------------------------

-- ----------------------------
-- Table structure for parametrorendimiento
-- ----------------------------
DROP TABLE IF EXISTS `parametrorendimiento`;
CREATE TABLE `parametrorendimiento` (
  `idprametro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `idproducto` int(11) NOT NULL,
  `valorsunat` decimal(20,4) NOT NULL,
  `valorunidad` decimal(20,4) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idprametro`) USING BTREE,
  KEY `frk_idproducto01` (`idproducto`) USING BTREE,
  CONSTRAINT `frk_idproducto01` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`idproducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of parametrorendimiento
-- ----------------------------

-- ----------------------------
-- Table structure for precio
-- ----------------------------
DROP TABLE IF EXISTS `precio`;
CREATE TABLE `precio` (
  `idprecio` int(11) NOT NULL AUTO_INCREMENT,
  `idunidadequivalente` int(11) NOT NULL,
  `idtipoprecio` int(11) NOT NULL,
  `idmoneda` int(11) NOT NULL,
  `precio` decimal(20,4) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idprecio`) USING BTREE,
  KEY `frk_idunidadequivalente002` (`idunidadequivalente`) USING BTREE,
  KEY `frk_idtipoprecio001` (`idtipoprecio`) USING BTREE,
  KEY `frk_idmoneda004` (`idmoneda`) USING BTREE,
  CONSTRAINT `frk_idmoneda004` FOREIGN KEY (`idmoneda`) REFERENCES `moneda` (`idmoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipoprecio001` FOREIGN KEY (`idtipoprecio`) REFERENCES `tipoprecio` (`idtipoprecio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idunidadequivalente002` FOREIGN KEY (`idunidadequivalente`) REFERENCES `unidadequivalente` (`idunidadequivalente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of precio
-- ----------------------------
INSERT INTO `precio` VALUES ('1', '1', '1', '1', '0.0000', '1', '2019-06-24 17:35:04');
INSERT INTO `precio` VALUES ('2', '2', '1', '1', '0.0000', '1', '2019-06-24 17:35:04');
INSERT INTO `precio` VALUES ('3', '3', '1', '1', '0.0000', '1', '2019-06-24 17:35:22');
INSERT INTO `precio` VALUES ('4', '4', '1', '1', '0.0000', '1', '2019-06-24 17:35:22');
INSERT INTO `precio` VALUES ('5', '5', '1', '1', '0.0000', '1', '2019-06-24 17:35:58');
INSERT INTO `precio` VALUES ('6', '6', '1', '1', '3.9000', '1', '2019-06-24 17:35:58');
INSERT INTO `precio` VALUES ('7', '7', '1', '1', '0.0000', '1', '2019-06-24 17:36:12');
INSERT INTO `precio` VALUES ('8', '8', '1', '1', '3.9000', '1', '2019-06-24 17:36:13');
INSERT INTO `precio` VALUES ('9', '9', '1', '1', '0.0000', '1', '2019-06-24 17:38:33');
INSERT INTO `precio` VALUES ('10', '10', '1', '1', '0.0000', '1', '2019-06-24 17:38:33');
INSERT INTO `precio` VALUES ('11', '11', '1', '1', '0.0000', '1', '2019-06-24 17:38:45');
INSERT INTO `precio` VALUES ('12', '12', '1', '1', '0.0000', '1', '2019-06-24 17:38:46');
INSERT INTO `precio` VALUES ('13', '13', '1', '1', '0.0000', '1', '2019-06-24 17:39:06');
INSERT INTO `precio` VALUES ('14', '14', '1', '1', '0.0000', '1', '2019-06-24 17:39:06');
INSERT INTO `precio` VALUES ('15', '15', '1', '1', '0.0000', '1', '2019-06-24 17:39:18');
INSERT INTO `precio` VALUES ('16', '16', '1', '1', '0.0000', '1', '2019-06-24 17:39:18');

-- ----------------------------
-- Table structure for producto
-- ----------------------------
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `idproducto` int(11) NOT NULL AUTO_INCREMENT,
  `idcategoria` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `pararendimiento` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  `norden` int(11) DEFAULT NULL,
  PRIMARY KEY (`idproducto`) USING BTREE,
  KEY `frk_idcategoria00` (`idcategoria`) USING BTREE,
  CONSTRAINT `frk_idcategoria00` FOREIGN KEY (`idcategoria`) REFERENCES `categoria` (`idcategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of producto
-- ----------------------------
INSERT INTO `producto` VALUES ('1', '1', 'POLLO VIVO CARNE', '0', '1', '2019-06-24 17:35:04', '1');
INSERT INTO `producto` VALUES ('2', '1', 'POLLO VIVO YY', '0', '1', '2019-06-24 17:35:22', '2');
INSERT INTO `producto` VALUES ('3', '2', 'POLLO BENEFICIADO CARNE', '0', '1', '2019-06-24 17:35:58', '3');
INSERT INTO `producto` VALUES ('4', '2', 'POLLO BENEFICIADO YY', '0', '1', '2019-06-24 17:36:12', '4');
INSERT INTO `producto` VALUES ('5', '3', 'MENUDENCIA', '0', '1', '2019-06-24 17:38:33', '5');
INSERT INTO `producto` VALUES ('6', '3', 'MOLLEJA', '0', '1', '2019-06-24 17:38:45', '6');
INSERT INTO `producto` VALUES ('7', '4', 'GALLINA', '0', '1', '2019-06-24 17:39:06', '7');
INSERT INTO `producto` VALUES ('8', '4', 'GALLINA DOBLE', '0', '1', '2019-06-24 17:39:18', '8');

-- ----------------------------
-- Table structure for productoalmacen
-- ----------------------------
DROP TABLE IF EXISTS `productoalmacen`;
CREATE TABLE `productoalmacen` (
  `idproductoalmacen` int(11) NOT NULL AUTO_INCREMENT,
  `idalmacen` int(11) NOT NULL,
  `idproducto` int(11) NOT NULL,
  `nunidad` decimal(20,4) NOT NULL,
  `pneto` decimal(20,4) NOT NULL,
  `costopromedio` decimal(20,4) NOT NULL,
  PRIMARY KEY (`idproductoalmacen`) USING BTREE,
  KEY `frk_idalmacen01` (`idalmacen`) USING BTREE,
  KEY `frk_idproducto02` (`idproducto`) USING BTREE,
  CONSTRAINT `frk_idalmacen01` FOREIGN KEY (`idalmacen`) REFERENCES `almacen` (`idalmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idproducto02` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`idproducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of productoalmacen
-- ----------------------------

-- ----------------------------
-- Table structure for proveedor
-- ----------------------------
DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `idproveedor` int(11) NOT NULL AUTO_INCREMENT,
  `razonsocial` varchar(255) NOT NULL,
  `idtipodocumento` int(11) NOT NULL,
  `documento` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idproveedor`) USING BTREE,
  KEY `frk_idtipodocumento02` (`idtipodocumento`) USING BTREE,
  CONSTRAINT `frk_idtipodocumento02` FOREIGN KEY (`idtipodocumento`) REFERENCES `tipodocumento` (`idtipodocumento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of proveedor
-- ----------------------------

-- ----------------------------
-- Table structure for serie
-- ----------------------------
DROP TABLE IF EXISTS `serie`;
CREATE TABLE `serie` (
  `idserie` int(11) NOT NULL AUTO_INCREMENT,
  `idalmacen` int(11) NOT NULL,
  `idtipocomprobante` int(11) NOT NULL,
  `nserie` varchar(255) NOT NULL,
  `ncorrelativo` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`idserie`) USING BTREE,
  UNIQUE KEY `ind_nserie_almacen` (`idalmacen`,`idtipocomprobante`,`nserie`) USING BTREE,
  KEY `frk_idalmacen03` (`idalmacen`) USING BTREE,
  KEY `frk_idtipocomprobante03` (`idtipocomprobante`) USING BTREE,
  CONSTRAINT `frk_idalmacen03` FOREIGN KEY (`idalmacen`) REFERENCES `almacen` (`idalmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipocomprobante03` FOREIGN KEY (`idtipocomprobante`) REFERENCES `tipocomprobante` (`idtipocomprobante`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of serie
-- ----------------------------
INSERT INTO `serie` VALUES ('1', '1', '1', '0001', '2', '1', '2019-04-28 21:34:01');
INSERT INTO `serie` VALUES ('2', '1', '2', '0001', '22', '1', '2019-04-28 21:36:01');

-- ----------------------------
-- Table structure for subproducto
-- ----------------------------
DROP TABLE IF EXISTS `subproducto`;
CREATE TABLE `subproducto` (
  `idsubproducto` int(11) NOT NULL AUTO_INCREMENT,
  `idproducto` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idsubproducto`) USING BTREE,
  KEY `frk_idproducto03` (`idproducto`) USING BTREE,
  CONSTRAINT `frk_idproducto03` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`idproducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of subproducto
-- ----------------------------

-- ----------------------------
-- Table structure for sucursal
-- ----------------------------
DROP TABLE IF EXISTS `sucursal`;
CREATE TABLE `sucursal` (
  `idsucursal` int(11) NOT NULL AUTO_INCREMENT,
  `idempresa` int(11) NOT NULL,
  `razonsocial` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `sede` varchar(255) NOT NULL,
  `telefono` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idsucursal`) USING BTREE,
  KEY `frk_idempresa00` (`idempresa`) USING BTREE,
  CONSTRAINT `frk_idempresa00` FOREIGN KEY (`idempresa`) REFERENCES `empresa` (`idempresa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of sucursal
-- ----------------------------
INSERT INTO `sucursal` VALUES ('1', '1', 'INVERSIONES NANDO´S CHICKEN SAC (CAMAL)', 'AV. TACNA NRO. 516 LAMBAYEQUE - FERREÑAFE - FERREÑAFE', 'FERREÑAFE', '---', '1', '2019-03-27 19:40:06');
INSERT INTO `sucursal` VALUES ('2', '1', 'INVERSIONES NANDO´S CHICKEN SAC (TIENDA I)', '--', 'FERREÑAFE', '--', '1', '2019-04-13 18:13:08');

-- ----------------------------
-- Table structure for tarjeta
-- ----------------------------
DROP TABLE IF EXISTS `tarjeta`;
CREATE TABLE `tarjeta` (
  `idtarjeta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`idtarjeta`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tarjeta
-- ----------------------------

-- ----------------------------
-- Table structure for tipocaja
-- ----------------------------
DROP TABLE IF EXISTS `tipocaja`;
CREATE TABLE `tipocaja` (
  `idtipocaja` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipocaja`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipocaja
-- ----------------------------

-- ----------------------------
-- Table structure for tipocambio
-- ----------------------------
DROP TABLE IF EXISTS `tipocambio`;
CREATE TABLE `tipocambio` (
  `idtipocambio` int(11) NOT NULL AUTO_INCREMENT,
  `idmoneda` int(11) NOT NULL,
  `compra` decimal(20,4) NOT NULL,
  `venta` decimal(20,4) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipocambio`) USING BTREE,
  KEY `frk_idmoneda01` (`idmoneda`) USING BTREE,
  CONSTRAINT `frk_idmoneda01` FOREIGN KEY (`idmoneda`) REFERENCES `moneda` (`idmoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipocambio
-- ----------------------------

-- ----------------------------
-- Table structure for tipocobro
-- ----------------------------
DROP TABLE IF EXISTS `tipocobro`;
CREATE TABLE `tipocobro` (
  `idtipocobro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipocobro`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipocobro
-- ----------------------------
INSERT INTO `tipocobro` VALUES ('1', 'EFECTIVO', 'EFEC', '1', '2019-05-08 22:11:13');
INSERT INTO `tipocobro` VALUES ('2', 'DEPOSITO', 'DEPO', '1', '2019-05-08 22:11:17');

-- ----------------------------
-- Table structure for tipocomprobante
-- ----------------------------
DROP TABLE IF EXISTS `tipocomprobante`;
CREATE TABLE `tipocomprobante` (
  `idtipocomprobante` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipocomprobante`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipocomprobante
-- ----------------------------
INSERT INTO `tipocomprobante` VALUES ('1', 'SALDO INICIAL', 'SINI', '1', '2019-04-14 20:35:51');
INSERT INTO `tipocomprobante` VALUES ('2', 'NOTA DE VENTA', 'NOTV', '1', '2019-04-14 20:36:17');

-- ----------------------------
-- Table structure for tipocuenta
-- ----------------------------
DROP TABLE IF EXISTS `tipocuenta`;
CREATE TABLE `tipocuenta` (
  `idtipocuenta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipocuenta`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipocuenta
-- ----------------------------

-- ----------------------------
-- Table structure for tipodocumento
-- ----------------------------
DROP TABLE IF EXISTS `tipodocumento`;
CREATE TABLE `tipodocumento` (
  `idtipodocumento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `longitud` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipodocumento`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipodocumento
-- ----------------------------
INSERT INTO `tipodocumento` VALUES ('1', 'DOCUMENTO DE INDENTIDAD', 'DNI', '11', '1', '2019-04-14 20:33:12');
INSERT INTO `tipodocumento` VALUES ('2', 'REGISTRO UNICO DEL CONTRIBUYENTE', 'RUC', '8', '1', '2019-04-14 20:33:27');
INSERT INTO `tipodocumento` VALUES ('3', 'SIN DOCUMENTO', 'S/D', '99', '1', '2019-04-14 20:33:48');

-- ----------------------------
-- Table structure for tipomovimiento
-- ----------------------------
DROP TABLE IF EXISTS `tipomovimiento`;
CREATE TABLE `tipomovimiento` (
  `idtipomovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipomovimiento`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipomovimiento
-- ----------------------------

-- ----------------------------
-- Table structure for tipooperacion
-- ----------------------------
DROP TABLE IF EXISTS `tipooperacion`;
CREATE TABLE `tipooperacion` (
  `idtipooperacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipooperacion`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipooperacion
-- ----------------------------
INSERT INTO `tipooperacion` VALUES ('1', 'INSERTAR', '1', '2019-03-14 10:41:53');
INSERT INTO `tipooperacion` VALUES ('2', 'ACTUALIZAR', '1', '2019-03-14 10:42:02');
INSERT INTO `tipooperacion` VALUES ('3', 'ELIMINAR', '1', '2019-03-14 10:42:10');

-- ----------------------------
-- Table structure for tipopago
-- ----------------------------
DROP TABLE IF EXISTS `tipopago`;
CREATE TABLE `tipopago` (
  `idtipopago` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `ndia` int(11) NOT NULL,
  `estado` int(1) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipopago`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipopago
-- ----------------------------
INSERT INTO `tipopago` VALUES ('1', 'CONTADO', '0', '1', '2019-04-29 20:51:38');
INSERT INTO `tipopago` VALUES ('2', 'CREDITO', '0', '1', '2019-04-29 20:52:19');
INSERT INTO `tipopago` VALUES ('3', 'CREDITO 30 DÍAS', '60', '1', '2019-04-29 20:53:18');

-- ----------------------------
-- Table structure for tipoprecio
-- ----------------------------
DROP TABLE IF EXISTS `tipoprecio`;
CREATE TABLE `tipoprecio` (
  `idtipoprecio` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipoprecio`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of tipoprecio
-- ----------------------------
INSERT INTO `tipoprecio` VALUES ('1', 'PUBLICO', '1', '2019-04-18 11:14:38');
INSERT INTO `tipoprecio` VALUES ('2', 'MAYOR', '1', '2019-04-18 11:14:53');
INSERT INTO `tipoprecio` VALUES ('3', 'MENOR', '1', '2019-04-18 11:15:01');

-- ----------------------------
-- Table structure for tipounidad
-- ----------------------------
DROP TABLE IF EXISTS `tipounidad`;
CREATE TABLE `tipounidad` (
  `idtipounidad` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipounidad`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipounidad
-- ----------------------------
INSERT INTO `tipounidad` VALUES ('1', 'BASE', '0', '2019-03-11 11:47:36');
INSERT INTO `tipounidad` VALUES ('2', 'COMPRA', '0', '2019-03-11 11:47:45');
INSERT INTO `tipounidad` VALUES ('3', 'VENTA', '1', '2019-03-11 11:47:51');

-- ----------------------------
-- Table structure for tipousuario
-- ----------------------------
DROP TABLE IF EXISTS `tipousuario`;
CREATE TABLE `tipousuario` (
  `idtipousuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idtipousuario`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tipousuario
-- ----------------------------
INSERT INTO `tipousuario` VALUES ('1', 'ADMINISTRADOR', 'ADMIN', '1', '2019-03-11 11:05:29');
INSERT INTO `tipousuario` VALUES ('2', 'CAJA', 'CAJA', '1', '2019-03-11 11:05:44');

-- ----------------------------
-- Table structure for unidadequivalente
-- ----------------------------
DROP TABLE IF EXISTS `unidadequivalente`;
CREATE TABLE `unidadequivalente` (
  `idunidadequivalente` int(11) NOT NULL AUTO_INCREMENT,
  `idproducto` int(11) NOT NULL,
  `idtipounidad` int(11) NOT NULL,
  `idunidadmedida` int(11) NOT NULL,
  `equivale` decimal(20,4) NOT NULL,
  `idunidadbase` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idunidadequivalente`) USING BTREE,
  KEY `frk_idproducto00` (`idproducto`) USING BTREE,
  KEY `frk_idtipounidad00` (`idtipounidad`) USING BTREE,
  KEY `frk_idunidadmedida00` (`idunidadmedida`) USING BTREE,
  KEY `frk_idunidabase00` (`idunidadbase`) USING BTREE,
  CONSTRAINT `frk_idproducto00` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`idproducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idtipounidad00` FOREIGN KEY (`idtipounidad`) REFERENCES `tipounidad` (`idtipounidad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idunidabase00` FOREIGN KEY (`idunidadbase`) REFERENCES `unidadmedida` (`idunidadmedida`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idunidadmedida00` FOREIGN KEY (`idunidadmedida`) REFERENCES `unidadmedida` (`idunidadmedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of unidadequivalente
-- ----------------------------
INSERT INTO `unidadequivalente` VALUES ('1', '1', '1', '1', '1.0000', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `unidadequivalente` VALUES ('2', '1', '3', '1', '1.0000', '1', '1', '2019-06-24 17:35:04');
INSERT INTO `unidadequivalente` VALUES ('3', '2', '1', '1', '1.0000', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `unidadequivalente` VALUES ('4', '2', '3', '1', '1.0000', '1', '1', '2019-06-24 17:35:22');
INSERT INTO `unidadequivalente` VALUES ('5', '3', '1', '1', '1.0000', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `unidadequivalente` VALUES ('6', '3', '3', '1', '1.0000', '1', '1', '2019-06-24 17:35:58');
INSERT INTO `unidadequivalente` VALUES ('7', '4', '1', '1', '1.0000', '1', '1', '2019-06-24 17:36:12');
INSERT INTO `unidadequivalente` VALUES ('8', '4', '3', '1', '1.0000', '1', '1', '2019-06-24 17:36:12');
INSERT INTO `unidadequivalente` VALUES ('9', '5', '1', '1', '1.0000', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `unidadequivalente` VALUES ('10', '5', '3', '1', '1.0000', '1', '1', '2019-06-24 17:38:33');
INSERT INTO `unidadequivalente` VALUES ('11', '6', '1', '1', '1.0000', '1', '1', '2019-06-24 17:38:45');
INSERT INTO `unidadequivalente` VALUES ('12', '6', '3', '1', '1.0000', '1', '1', '2019-06-24 17:38:45');
INSERT INTO `unidadequivalente` VALUES ('13', '7', '1', '1', '1.0000', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `unidadequivalente` VALUES ('14', '7', '3', '1', '1.0000', '1', '1', '2019-06-24 17:39:06');
INSERT INTO `unidadequivalente` VALUES ('15', '8', '1', '1', '1.0000', '1', '1', '2019-06-24 17:39:18');
INSERT INTO `unidadequivalente` VALUES ('16', '8', '3', '1', '1.0000', '1', '1', '2019-06-24 17:39:18');

-- ----------------------------
-- Table structure for unidadmedida
-- ----------------------------
DROP TABLE IF EXISTS `unidadmedida`;
CREATE TABLE `unidadmedida` (
  `idunidadmedida` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `sigla` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idunidadmedida`) USING BTREE,
  UNIQUE KEY `ind_sigla01` (`sigla`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of unidadmedida
-- ----------------------------
INSERT INTO `unidadmedida` VALUES ('1', 'KILOGRAMO', 'KG', '1', '2019-04-16 21:51:59');
INSERT INTO `unidadmedida` VALUES ('2', 'GRAMO', 'GR', '1', '2019-04-16 21:56:45');

-- ----------------------------
-- Table structure for usuario
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `idtipousuario` int(11) NOT NULL,
  `nombreyapellido` varchar(255) NOT NULL,
  `cuenta` varchar(255) NOT NULL,
  `clave` varchar(255) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idusuario`) USING BTREE,
  UNIQUE KEY `index_cuenta01` (`cuenta`) USING BTREE,
  KEY `frk_idtipousuario00` (`idtipousuario`) USING BTREE,
  CONSTRAINT `frk_idtipousuario00` FOREIGN KEY (`idtipousuario`) REFERENCES `tipousuario` (`idtipousuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES ('1', '1', 'ADMIN', 'ADMIN', '1234', '1', '2019-03-14 10:58:44');
INSERT INTO `usuario` VALUES ('2', '2', 'CAJA', 'CAJA', '1234', '1', '2019-04-11 23:12:49');

-- ----------------------------
-- Table structure for usuarioalmacen
-- ----------------------------
DROP TABLE IF EXISTS `usuarioalmacen`;
CREATE TABLE `usuarioalmacen` (
  `idusuarioalmacen` int(11) NOT NULL AUTO_INCREMENT,
  `idalmacen` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `fecharegistro` datetime NOT NULL,
  PRIMARY KEY (`idusuarioalmacen`) USING BTREE,
  KEY `frk_idusuario0` (`idusuario`) USING BTREE,
  KEY `frk_idalmacen04` (`idalmacen`) USING BTREE,
  CONSTRAINT `frk_idalmacen04` FOREIGN KEY (`idalmacen`) REFERENCES `almacen` (`idalmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `frk_idusuario0` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of usuarioalmacen
-- ----------------------------
INSERT INTO `usuarioalmacen` VALUES ('1', '1', '1', '1', '2019-03-29 18:58:31');
INSERT INTO `usuarioalmacen` VALUES ('2', '2', '1', '1', '2019-04-13 18:14:36');
INSERT INTO `usuarioalmacen` VALUES ('3', '1', '2', '1', '2019-06-07 15:12:29');

-- ----------------------------
-- Procedure structure for Sp_actualizar_almacen
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_almacen`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_almacen`(in _idalmacen int(11),
in _idsucursal int(11),
in _nombre VARCHAR(255),
in _direccion VARCHAR(255),
in _telefono VARCHAR(255),
in _estado int(11),
in _idusuario int(11))
begin

declare _filas_afectadas int(11) default 0;

update almacen set 
idalmacen=_idalmacen,
idsucursal=_idsucursal,
nombre=_nombre,
direccion=_direccion,
telefono=_telefono,
estado=_estado
where idalmacen=_idalmacen;

set _filas_afectadas=(select ROW_COUNT());

call sp_registrar_auditoria(_idalmacen,"ALMACEN",_idusuario,2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_categoria
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_categoria`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_categoria`(in _idcategoria int(11),
in _nombre VARCHAR(255),
in _estado VARCHAR(255),
in _idusuario int(11))
begin 

declare _filas_afectadas int(11) default -1;

update categoria set 
idcategoria=_idcategoria,
nombre=_nombre,
estado=_estado
where idcategoria=_idcategoria;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "CATEGORIA", _idcategoria, 2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_cliente
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_cliente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_cliente`(in _idcliente int(11),
in _razonsocial VARCHAR(255),
in _idtipodocumento int(11),
in _documento VARCHAR(255),
in _direccion VARCHAR(255),
in _estado int(11),
in _idusuario int(11))
begin

declare _filas_afectadas int(11) default -1;

update cliente set 
razonsocial=_razonsocial,
idtipodocumento=_idtipodocumento,
documento=_documento,
direccion=_direccion,
estado=_estado
where idcliente=_idcliente;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "CLIENTE", _idcliente, 2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_deuda
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_deuda`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_deuda`(in _iddeuda int(11),
in _monto decimal(20,4),
in _idusuario int(11))
begin 

update deuda set 
montototal=montototal+_monto,
montoactual=montototal-montocobrado
where iddeuda=_iddeuda;

call Sp_registrar_auditoria(_idusuario, "DEUDA",_iddeuda , 2);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_empresa
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_empresa`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_empresa`(in _idempresa int(11),
in _idtipodocumento int(11),
in _razonsocial VARCHAR(255),
in _ruc VARCHAR(255),
in _direccion VARCHAR(255),
in _telefono VARCHAR(255),
in _estado int(11),
in _idusuario int(11))
begin

declare _filas_afectadas int(11) default 0;

update empresa set 
idtipodocumento=_idtipodocumento,
razonsocial=_razonsocial,
ruc=_ruc,
direccion=_direccion,
telefono=_telefono,
estado=_estado
where idempresa=_idempresa;

set _filas_afectadas=(select ROW_COUNT());

call sp_registrar_auditoria(_idempresa,"EMPRESA",_idusuario,2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_precio
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_precio`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_precio`(in _idprecio int(11),
in _idtipoprecio int(11),
in _idmoneda int(11),
in _precio decimal(20,4),
in _estado int(11),
in _idusuario int(11))
begin 

declare _filas_afectadas int(11) default -1;

update precio set 
idtipoprecio=_idtipoprecio,
idmoneda=_idmoneda,
precio=_precio,
estado=_estado
where idprecio=_idprecio;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "PRECIO", _idprecio, 2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_producto
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_producto`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_producto`(in _idproducto int(11),
in _idcategoria int(11),
in _nombre VARCHAR(255),
in _estado int(11),
in _idunidadmedida int(11),
in _precio decimal(20,4),
in _idusuario int(11), in _norden int(11))
begin 

declare _filas_afectadas int(11) default -1;
declare _iduniequiv int(11) default -1;
declare _idprecio int(11) default -1;
declare _idunidadbase int(11) default -1;

update producto set
idcategoria=_idcategoria,
nombre=_nombre,
estado=_estado,
norden=_norden
where idproducto=_idproducto;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "PRODUCTO", _idproducto, 2);

/* Actualiza BASE*/

set _idunidadbase=(select idunidadbase from unidadequivalente where idproducto=_idproducto and idtipounidad=1);
set _iduniequiv=(select idunidadequivalente from unidadequivalente where idproducto=_idproducto and idtipounidad=1);

update unidadequivalente set 
idunidadmedida=_idunidadmedida,
idunidadbase=_idunidadmedida
where idunidadequivalente=_iduniequiv;

call Sp_registrar_auditoria(_idusuario, "UNIDADEQUIVALENTE", _iduniequiv, 2);


/* Actualiza PRECIO PUBLICO DE UNIDAD BASE*/

set _iduniequiv=(select idunidadequivalente from unidadequivalente where idproducto=_idproducto and idtipounidad=3 and idunidadmedida=_idunidadbase);

update unidadequivalente set 
idunidadmedida=_idunidadmedida,
idunidadbase=_idunidadmedida
where idunidadequivalente=_iduniequiv;

call Sp_registrar_auditoria(_idusuario, "UNIDADEQUIVALENTE", _iduniequiv, 2);

set _idprecio=(select idprecio from precio where idunidadequivalente=_iduniequiv and idtipoprecio=1);

update precio set 
precio=_precio
where idprecio=_idprecio ;


call Sp_registrar_auditoria(_idusuario, "PRECIO", _idprecio, 2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_serie
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_serie`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_serie`(in _idserie int(11),
in _idalmacen int(11),
in _idtipocomprobante int(11),
in _nserie VARCHAR(255),
in _ncorrelativo int(11),
in _estado int(11),
in _idusuario int(11))
begin 

declare _filas_afectadas int(11) default -1;

update serie set 
idalmacen=_idalmacen,
idtipocomprobante=_idtipocomprobante,
nserie=_nserie,
ncorrelativo=_ncorrelativo,
estado=_estado
where idserie=_idserie;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "SERIE", _idserie, 2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_sucursal
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_sucursal`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_sucursal`(in _idsucursal int(11),
in _idempresa int(11),
in _razonsocial VARCHAR(255),
in _direccion VARCHAR(255),
in _sede VARCHAR(255),
in _telefono VARCHAR(255),
in _estado int(11),
in _idusuario int(11))
begin

declare _filas_afectadas int(11) default 0;

update sucursal set
idempresa=_idempresa,
razonsocial=_razonsocial,
direccion=_direccion,
sede=_sede,
telefono=_telefono,
estado=_estado
where idsucursal=_idsucursal;

set _filas_afectadas=(select ROW_COUNT());

call sp_registrar_auditoria(_idsucursal,"SUCURSAL",_idusuario,2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_unidadequivalente
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_unidadequivalente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_unidadequivalente`(in _idunidadequivalente int(11),
in _idtipounidad int(11),
in _idunidadmedida int(11),
in _equivale decimal(20,4),
in _idunidadbase int(11),
in _estado int(11),
in _idusuario int(11))
begin 

declare _filas_afectadas int(11) default -1;
declare _existeunidad int(11) default -1 ;

set _existeunidad=(
select count(*)
from unidadequivalente
where idproducto=(select idproducto from unidadequivalente where idunidadequivalente=_idunidadequivalente) and idunidadmedida=_idunidadmedida and idtipounidad=_idtipounidad
);

if(_existeunidad=1)then

update unidadequivalente set 
idtipounidad=_idtipounidad,
idunidadmedida=_idunidadmedida,
equivale=_equivale,
idunidadbase=_idunidadbase,
estado=_estado
where idunidadequivalente=_idunidadequivalente;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "UNIDADEQUIVALENTE", _idunidadequivalente, 2);


end if;

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_unidadmedida
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_unidadmedida`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_unidadmedida`(in _idunidadmedida int(11),
in _nombre VARCHAR(255),
in _sigla VARCHAR(255),
in _estado int(11),
in _idusuario int(11))
begin

declare _filas_afectadas int(11) default -1;

update unidadmedida set 
nombre=_nombre,
sigla=_sigla,
estado=_estado
where idunidadmedida=_idunidadmedida;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "UNIDADMEDIDA", _idunidadmedida, 2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_usuario`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_usuario`(in _idusuario int(11),
in _idtipousuario int(11),
in _nombreyapellido VARCHAR (255),
in _cuenta VARCHAR(255),
in _clave VARCHAR(255),
in _estado int(11),
in _idusu int(11))
begin 

declare _filas_afectadas int(11) default 0;

update usuario
set 
idtipousuario=_idtipousuario,
nombreyapellido=_nombreyapellido,
cuenta=_cuenta,
clave=_clave,
estado=_estado
where idusuario=_idusuario;

set _filas_afectadas=(select ROW_COUNT());

call sp_registrar_auditoria(_idusu,"USUARIO",_idusuario,2);

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_actualizar_usuarioalmacen
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_actualizar_usuarioalmacen`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_actualizar_usuarioalmacen`(in _idusuarioalmacen int(11),
in _idalmacen int(11),
in _idusuarioenalmacen int(11),
in _estado int(11),
in _idusuario int(11))
begin

declare _filas_afectadas int(11) default 0;
declare _existe int(11) default 0;

set _existe=(
select COUNT(*)
from usuarioalmacen
where idusuario=_idusuarioenalmacen and idalmacen=_idalmacen
);

if(_existe=0)then

update usuarioalmacen set 
idalmacen=_idalmacen,
idusuario=_idusuarioenalmacen,
estado=_estado
where idusuarioalmacen=_idusuarioalmacen;

set _filas_afectadas=(select ROW_COUNT());

call sp_registrar_auditoria(_idusuarioalmacen,"USUARIOALMACEN",_idusuario,2);

else


set _filas_afectadas=-1;

end if;

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_anular_cobro
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_anular_cobro`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_anular_cobro`(in _iddeuda int(11),
in _idcobro int(11),
in _idusuario int(11))
begin 

declare _filas_afectadas int(11);
declare _monto decimal(20,4);

select monto into _monto from cobro where idcobro=_idcobro;

update cobro set estado=0 where idcobro=_idcobro;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "COBRO", _idcobro, 2);

UPDATE deuda set 
montocobrado=montocobrado-_monto,
montoactual=montototal-montocobrado
where iddeuda=_iddeuda;

select _filas_afectadas;


end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_anular_comprobantexidcomprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_anular_comprobantexidcomprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_anular_comprobantexidcomprobante`(in _idcomprobante int(11),
in _idusuario int(11))
begin 

declare _filas_afectadas int(11) default -1;
declare _idcliente int(11);
declare _monto decimal(20,4);
declare _iddeuda int(11);
declare _idtipocomprobante int(11);

set _idtipocomprobante=(
select s.idtipocomprobante
from comprobante c
INNER JOIN serie s on c.idserie=s.idserie
where c.idcomprobante=_idcomprobante 
);

select idcliente, total into _idcliente, _monto
from comprobante 
where idcomprobante=_idcomprobante;

select iddeuda into _iddeuda
from deuda 
where idcliente=_idcliente and estado=1;

update comprobante set estado=0 
where idcomprobante=_idcomprobante;

set _filas_afectadas=(select ROW_COUNT());

call Sp_registrar_auditoria(_idusuario, "COMPROBANTE",_idcomprobante , 2);

update detallecomprobante set estado=0 
where idcomprobante=_idcomprobante;

call Sp_actualizar_deuda(_iddeuda,(-1*_monto),_idusuario);

if(_idtipocomprobante=1)then

update deuda set 
montoinicial=montoinicial-_monto
where iddeuda=_iddeuda;

call Sp_registrar_auditoria(_idusuario, "DEUDA",_iddeuda , 2);

end if;

select _filas_afectadas;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_imprimir_comprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_imprimir_comprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_imprimir_comprobante`(in _idcomprobante int(11),
in _ocultar int(11))
begin 

declare _saldoanterior decimal(20,4) default 0;
declare _cuentatotal decimal(20,4) default 0;
declare _acuenta decimal(20,4) default 0;
declare _totalcobrado decimal(20,4) default 0;

set _totalcobrado=(
select ifnull(sum(monto),0.00)
from cobro
where iddeuda=(select iddeuda from deuda where idcliente=(select idcliente from comprobante where idcomprobante=_idcomprobante and estado=1))
and estado=1
and date(fecharegistro)<(select fechaemision from comprobante where idcomprobante=_idcomprobante and estado=1)
);

set _saldoanterior=(
select ifnull(sum(total),0.00)
from comprobante
where idcliente =(select idcliente from comprobante where idcomprobante=_idcomprobante and estado=1)
and estado=1 
and fechaemision<(select fechaemision from comprobante where idcomprobante=_idcomprobante and estado=1)
);

set _saldoanterior=_saldoanterior-_totalcobrado;

set _cuentatotal=(
select ifnull(sum(total),0.00)
from comprobante
where idcliente =(select idcliente from comprobante where idcomprobante=_idcomprobante and estado=1)
and estado=1 
and fechaemision<=(select fechaemision from comprobante where idcomprobante=_idcomprobante and estado=1)
);

set _cuentatotal=_cuentatotal-_totalcobrado;

set _acuenta=(
select ifnull(sum(monto),0.00)
from cobro
where iddeuda=(select iddeuda from deuda where idcliente=(select idcliente from comprobante where idcomprobante=_idcomprobante and estado=1))
and estado=1
and date(fecharegistro)=(select fechaemision from comprobante where idcomprobante=_idcomprobante and estado=1)
);



set @rownum=0;

select
@rownum:=@rownum+1 AS item,
e.razonsocial as erazonsocial,
e.ruc,
e.direccion,
e.telefono as etelefono,
CONCAT(t.nombre," :") as tnombre,
c.nserie,
c.ncorrelativo,
c.ncomprobante,
cli.razonsocial as clirazonsocial,
DATE_FORMAT(c.fechaemision, "%d/%m/%Y") as fechaemision,
pro.nombre,
dt.nunidad,
dt.pbruto,
dt.ptara,
dt.pneto,
if(_ocultar=1,0.00,dt.preciounitario) as preciounitario,
dt.total,
if(c.estado=1,"REGISTRADO","ANULADO") as estado,
_saldoanterior,
_cuentatotal,
_acuenta,
(_cuentatotal-_acuenta) as _saldo,
pro.norden,
usu.nombreyapellido,
c.glosa
from comprobante c
INNER JOIN serie s on c.idserie=s.idserie
INNER JOIN almacen a on s.idalmacen=a.idalmacen
INNER JOIN sucursal su on a.idsucursal=su.idsucursal
INNER JOIN empresa e on su.idempresa=e.idempresa
INNER JOIN tipocomprobante t on s.idtipocomprobante=t.idtipocomprobante
INNER JOIN cliente cli on c.idcliente=cli.idcliente
INNER JOIN detallecomprobante dt on c.idcomprobante=dt.idcomprobante
INNER JOIN producto pro on dt.idproducto=pro.idproducto and c.idcomprobante=_idcomprobante
inner join usuario usu ON usu.idusuario=c.idusuario
order by pro.norden ASC;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_almacen
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_almacen`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_almacen`()
begin 

select
idalmacen,
idsucursal,
nombre,
direccion,
telefono,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from almacen;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_almacenxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_almacenxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_almacenxestado`()
begin 

select
idalmacen,
idsucursal,
nombre,
direccion,
telefono,
estado
from almacen
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_almacenxidsucursal
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_almacenxidsucursal`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_almacenxidsucursal`(in _idsucursal int(11))
begin 

select
idalmacen,
idsucursal,
nombre,
direccion,
telefono,
estado
from almacen
where idsucursal=_idsucursal and estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_almacenxnombre
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_almacenxnombre`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_almacenxnombre`(in _nombre VARCHAR(255))
begin 

select
idalmacen,
idsucursal,
nombre,
direccion,
telefono,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from almacen
where nombre like CONCAT('%',_nombre,'%');
end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_categoria
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_categoria`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_categoria`()
begin 

select 
idcategoria,
nombre,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from categoria;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_categoriaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_categoriaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_categoriaxestado`()
begin 

select 
idcategoria,
nombre,
estado
from categoria
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_categoriaxnombre
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_categoriaxnombre`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_categoriaxnombre`(in _nombre VARCHAR(255))
begin 

select 
idcategoria,
nombre,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from categoria
where nombre like CONCAT('%',_nombre,'%');

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_cliente
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_cliente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_cliente`()
begin 

select 
c.idcliente,
c.razonsocial,
c.idtipodocumento,
td.sigla,
c.documento,
c.direccion,
if(c.estado=1,'ACTIVO','NO ACTIVO') as estado
from cliente c
INNER JOIN tipodocumento td on c.idtipodocumento=td.idtipodocumento;
end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_clientexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_clientexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_clientexestado`()
begin 

select 
c.idcliente,
c.razonsocial,
c.idtipodocumento,
td.sigla,
c.documento,
c.direccion,
c.estado
from cliente c
INNER JOIN tipodocumento td on c.idtipodocumento=td.idtipodocumento
where c.estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_clientexrazonsocial
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_clientexrazonsocial`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_clientexrazonsocial`(in _razonsocial VARCHAR(255))
begin 

select 
c.idcliente,
c.razonsocial,
c.idtipodocumento,
td.sigla,
c.documento,
c.direccion,
if(c.estado=1,'ACTIVO','NO ACTIVO') as estado
from cliente c
INNER JOIN tipodocumento td on c.idtipodocumento=td.idtipodocumento
where c.razonsocial like concat('%',_razonsocial,'%');

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_cobroxfechaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_cobroxfechaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_cobroxfechaxestado`(in _fechainicio date,
in _fechafin date, 
in _estado int(11))
begin

select 
co.idcobro,
co.iddeuda,
cl.razonsocial, 
DATE_FORMAT(co.fechacobro, "%d/%m/%Y") as fechacobro,
co.idtipocobro,
tc.nombre,
co.idmoneda,
co.cuentabancaria,
co.noperacion,
round(co.monto,2) as monto,
co.observacion,
if(co.estado='1', 'REGISTRADO','ANULADO') as estado
from cobro co
INNER JOIN tipocobro tc on co.idtipocobro=tc.idtipocobro
INNER JOIN deuda de on co.iddeuda=de.iddeuda
INNER JOIN cliente cl on de.idcliente=cl.idcliente
where  co.fechacobro BETWEEN _fechainicio and  _fechafin and
(case 
when _estado=0 then
co.estado in (0,1)
when _estado=1 or _estado=2 then
co.estado=_estado
end);
end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_cobroxidcobro
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_cobroxidcobro`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_cobroxidcobro`(in _idcobro int(11))
begin 

select 
idcobro,
iddeuda,
fechacobro,
idtipocobro,
idmoneda,
cuentabancaria,
noperacion,
ROUND(monto,2) as monto,
observacion,
estado
from cobro
where idcobro=_idcobro;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_cobroxiddeudaxfechaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_cobroxiddeudaxfechaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_cobroxiddeudaxfechaxestado`(in _iddeuda int(11),
in _fechainicio date,
in _fechafin date, 
in _estado int(11))
begin

select 
co.idcobro,
co.iddeuda,
DATE_FORMAT(co.fechacobro, "%d/%m/%Y") as fechacobro,
co.idtipocobro,
tc.nombre,
co.idmoneda,
co.cuentabancaria,
co.noperacion,
ROUND(co.monto,2) as monto,
co.observacion,
if(co.estado='1', 'REGISTRADO','ANULADO') as estado
from cobro co
INNER JOIN tipocobro tc on co.idtipocobro=tc.idtipocobro
where co.iddeuda=_iddeuda and
(case 
when _estado=0 then
co.estado in (0,1) 
when _estado=1 or _estado=2 then
co.estado=_estado
when _estado=3 then
co.fechacobro BETWEEN _fechainicio and  _fechafin

end);
end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado`(in _idalmacen int(11),
in _fechainicio date,
in _fechafin date,
in _ncomprobante VARCHAR(255),
in _estado int(11))
begin 

select 
c.idcomprobante,
s.idtipocomprobante,
tc.nombre as tcnombre,
c.idserie,
c.nserie,
c.ncorrelativo,
c.ncomprobante,
DATE_FORMAT(c.fechaemision, "%d/%m/%Y") as fechaemision,
c.idtipopago,
c.idcliente,
cl.razonsocial as clrazonsocial,
c.idmoneda,
ROUND(c.subtotal,2) as subtotal,
ROUND(c.igv,2) as igv,
ROUND(c.total,2) as total,
c.descripcion,
c.idusuario,
u.nombreyapellido as nusuario,
if(c.estado=1,'REGISTRADO','ANULADO') as estado
from comprobante c
INNER JOIN serie s on c.idserie=s.idserie
INNER JOIN tipocomprobante tc on s.idtipocomprobante=tc.idtipocomprobante
INNER JOIN cliente cl on c.idcliente=cl.idcliente
INNER JOIN usuario u on c.idusuario=u.idusuario
where s.idalmacen=_idalmacen and date(c.fechaemision) BETWEEN date(_fechainicio) and date(_fechafin) and
(case
when _estado=0 then
c.estado in(1,0)
when _estado=1 then
c.estado=1
when _estado=2 then
c.estado=0
end)
and 
(case 
when LENGTH(_ncomprobante)>0 then  
c.ncomprobante like CONCAT('%',_ncomprobante,'%')

else

true

end);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_comprobantexidclientexfechaxncomprobantexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_comprobantexidclientexfechaxncomprobantexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_comprobantexidclientexfechaxncomprobantexestado`(in _idcliente int(11),
in _fechainicio date,
in _fechafin date,
in _ncomprobante VARCHAR(255),
in _estado int(11))
begin 

select 
c.idcomprobante,
s.idtipocomprobante,
tc.nombre as tcnombre,
c.idserie,
c.nserie,
c.ncorrelativo,
c.ncomprobante,
DATE_FORMAT(c.fechaemision, "%d/%m/%Y") as fechaemision,
c.idtipopago,
c.idcliente,
cl.razonsocial as clrazonsocial,
c.idmoneda,
ROUND(c.subtotal,2) as subtotal,
ROUND(c.igv,2) as igv,
ROUND(c.total,2) as total,
c.descripcion,
c.idusuario,
u.nombreyapellido as nusuario,
if(c.estado=1,'REGISTRADO','ANULADO') as estado
from comprobante c
INNER JOIN serie s on c.idserie=s.idserie
INNER JOIN tipocomprobante tc on s.idtipocomprobante=tc.idtipocomprobante
INNER JOIN cliente cl on c.idcliente=cl.idcliente
INNER JOIN usuario u on c.idusuario=u.idusuario
where c.idcliente=_idcliente and date(c.fechaemision) BETWEEN date(_fechainicio) and date(_fechafin) and
(case
when _estado=0 then
c.estado in(1,0)
when _estado=1 then
c.estado=1
when _estado=2 then
c.estado=0
end)
and 
(case 
when LENGTH(_ncomprobante)>0 then  
c.ncomprobante like CONCAT('%',_ncomprobante,'%')

else

true

end);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_comprobantexidcomprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_comprobantexidcomprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_comprobantexidcomprobante`(in _idcomprobante int(11))
begin 

select 
c.idcomprobante,
c.idserie,
s.idtipocomprobante,
tc.nombre as tcnombre,
c.nserie,
c.ncorrelativo,
c.ncomprobante,
c.fechaemision,
c.idtipopago,
c.idcliente,
c.idmoneda,
round(c.subtotal,2) as subtotal,
round(c.igv,2) as igv,
round(c.total,2) as total,
c.descripcion,
c.idusuario,
c.estado,
c.glosa
from comprobante c
INNER JOIN serie s on c.idserie=s.idserie
INNER JOIN tipocomprobante tc on s.idtipocomprobante=tc.idtipocomprobante
where idcomprobante=_idcomprobante;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_detallecomprobantexidcomprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_detallecomprobantexidcomprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_detallecomprobantexidcomprobante`(in _idcomprobante int(11))
begin 

select 
d.iddetallecomprobante,
d.idcomprobante,
d.idproducto,
p.nombre,
d.idunidadequivalente,
um.sigla as umsigla,
round(d.nunidad,2) as nunidad,
round(d.pbruto,2) as pbruto,
round(d.ptara,2) as ptara,
round(d.pneto,2) as pneto,
round(d.preciounitario,2) as preciounitario,
round(d.subtotal,2) as subtotal,
round(d.igv,2) as igv,
round(d.total,2) as total,
d.estado
from detallecomprobante d
INNER JOIN producto p on  d.idproducto=p.idproducto
INNER JOIN unidadequivalente uq on d.idunidadequivalente=uq.idunidadequivalente
INNER JOIN unidadmedida um on uq.idunidadmedida= um.idunidadmedida
where idcomprobante=_idcomprobante;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_deudaxidclientexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_deudaxidclientexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_deudaxidclientexestado`(in _idcliente int(11))
begin 

select 
iddeuda,
idcliente,
round(montoinicial,2) as montoinicial,
round(montototal,2) as montototal,
round(montocobrado,2) as montocobrado,
round(montoactual,2) as montoactual,
estado
from deuda
where idcliente=_idcliente and estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_deudaxiddeudaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_deudaxiddeudaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_deudaxiddeudaxestado`(in _iddeuda int(11))
begin 

select 
iddeuda,
idcliente,
round(montoinicial,2) as montoinicial,
round(montototal,2) as montototal,
round(montocobrado,2) as montocobrado,
round(montoactual,2) as montoactual,
estado
from deuda
where iddeuda=_iddeuda and estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_empresa
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_empresa`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_empresa`()
begin

select 
e.idempresa,
e.idtipodocumento,
td.sigla,
e.razonsocial,
e.ruc,
e.direccion,
e.telefono,
if(e.estado=1,'ACTIVO','NO ACTIVO') as estado
from empresa e
INNER JOIN tipodocumento td on e.idtipodocumento=td.idtipodocumento;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_empresaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_empresaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_empresaxestado`()
begin

select 
e.idempresa,
e.idtipodocumento,
td.sigla,
e.razonsocial,
e.ruc,
e.direccion,
e.telefono,
e.estado
from empresa e
INNER JOIN tipodocumento td on e.idtipodocumento=td.idtipodocumento 
where e.estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_empresaxnumeroruc
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_empresaxnumeroruc`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_empresaxnumeroruc`(in _ruc VARCHAR(255))
begin

select 
e.idempresa,
e.idtipodocumento,
td.sigla,
e.razonsocial,
e.ruc,
e.direccion,
e.telefono,
e.estado
from empresa e
INNER JOIN tipodocumento td on e.idtipodocumento=td.idtipodocumento
where e.ruc =_ruc;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_empresaxrazonsocial
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_empresaxrazonsocial`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_empresaxrazonsocial`(in _razonsocial VARCHAR(255))
begin

select 
e.idempresa,
e.idtipodocumento,
td.sigla,
e.razonsocial,
e.ruc,
e.direccion,
e.telefono,
if(e.estado=1,'ACTIVO','NO ACTIVO') as estado
from empresa e
INNER JOIN tipodocumento td on e.idtipodocumento=td.idtipodocumento
where e.razonsocial like CONCAT('%',_razonsocial,'%');

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_empresaxruc
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_empresaxruc`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_empresaxruc`(in _ruc VARCHAR(255))
begin

select 
e.idempresa,
e.idtipodocumento,
td.sigla,
e.razonsocial,
e.ruc,
e.direccion,
e.telefono,
if(e.estado=1,'ACTIVO','NO ACTIVO') as estado
from empresa e
INNER JOIN tipodocumento td on e.idtipodocumento=td.idtipodocumento
where e.ruc like CONCAT('%',_ruc,'%');

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_monedaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_monedaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_monedaxestado`()
begin

select 
idmoneda,
nombre,
sigla,
estado
from moneda 
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_precioxidunidadequivalente
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_precioxidunidadequivalente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_precioxidunidadequivalente`(in _idunidadequivalente int(11))
begin 

select 
p.idprecio,
p.idunidadequivalente,
um.sigla as umsigla,
p.idtipoprecio,
tp.nombre as  tpnombre,
p.idmoneda,
m.sigla,
round(p.precio,2) as precio,
if(p.estado=1,'ACTIVO','NO ACTIVO') as estado
from precio p
INNER JOIN tipoprecio tp on p.idtipoprecio=tp.idtipoprecio
INNER JOIN moneda m on p.idmoneda=m.idmoneda
INNER JOIN unidadequivalente uq on p.idunidadequivalente=uq.idunidadequivalente
INNER JOIN unidadmedida um on uq.idunidadmedida=um.idunidadmedida
where p.idunidadequivalente=_idunidadequivalente;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_precioxidunidadequivalentexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_precioxidunidadequivalentexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_precioxidunidadequivalentexestado`(in _idunidadequivalente int(11))
begin 

select 
p.idprecio,
p.idunidadequivalente,
p.idtipoprecio,
tp.nombre as  tpnombre,
p.idmoneda,
m.sigla,
round(p.precio,2) as precio,
p.estado
from precio p
INNER JOIN tipoprecio tp on p.idtipoprecio=tp.idtipoprecio
INNER JOIN moneda m on p.idmoneda=m.idmoneda
where p.idunidadequivalente=_idunidadequivalente and p.estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_productoxcategoria
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_productoxcategoria`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_productoxcategoria`(in _idcategoria int(11))
begin 

select 
p.idproducto,
p.idcategoria,
c.nombre as canombre,
p.nombre as prnombre,
eqv.idunidadmedida,
uni.sigla,
round(pre.precio,2) as precio,
if(p.estado=1,'ACTIVO','NO ACTIVO') as estado,
p.norden
from producto p
left JOIN categoria c on p.idcategoria=c.idcategoria
LEFT JOIN unidadequivalente eqv on p.idproducto=eqv.idproducto
LEFT JOIN unidadmedida uni on eqv.idunidadmedida=uni.idunidadmedida
LEFT JOIN precio pre on eqv.idunidadequivalente=pre.idunidadequivalente
where eqv.idtipounidad=3 and
eqv.idunidadbase=eqv.idunidadmedida and
p.idcategoria=_idcategoria and 
pre.idtipoprecio=1
order BY p.norden asc;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_productoxcategoriaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_productoxcategoriaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_productoxcategoriaxestado`(in _idcategoria int(11),
in _nombre VARCHAR(255))
begin 

select 
p.idproducto,
p.idcategoria,
c.nombre as canombre,
p.nombre as prnombre,
eqv.idunidadmedida,
uni.sigla,
round(pre.precio,2) as precio
from producto p
INNER JOIN categoria c on p.idcategoria=c.idcategoria
INNER JOIN unidadequivalente eqv on p.idproducto=eqv.idproducto
INNER JOIN unidadmedida uni on eqv.idunidadmedida=uni.idunidadmedida
INNER JOIN precio pre on eqv.idunidadequivalente=pre.idunidadequivalente
where eqv.idtipounidad=3 and
eqv.idunidadbase=eqv.idunidadmedida and
p.idcategoria=_idcategoria and 
pre.idtipoprecio=1 and p.nombre like CONCAT('%',_nombre,'%') and p.estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_productoxcategoriaxestadoxnombre
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_productoxcategoriaxestadoxnombre`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_productoxcategoriaxestadoxnombre`(in _idcategoria int(11),
in _nombre VARCHAR(255))
begin 

select 
p.idproducto,
p.idcategoria,
c.nombre as canombre,
p.nombre as prnombre,
eqv.idunidadmedida,
uni.sigla,
round(pre.precio,2) as precio
from producto p
INNER JOIN categoria c on p.idcategoria=c.idcategoria
INNER JOIN unidadequivalente eqv on p.idproducto=eqv.idproducto
INNER JOIN unidadmedida uni on eqv.idunidadmedida=uni.idunidadmedida
INNER JOIN precio pre on eqv.idunidadequivalente=pre.idunidadequivalente
where eqv.idtipounidad=3 and
eqv.idunidadbase=eqv.idunidadmedida and
p.idcategoria=_idcategoria and 
pre.idtipoprecio=1 and p.estado=1 and (
case  when LENGTH(_nombre)>0 then 
p.nombre like CONCAT('%',_nombre,'%')
else
true
end);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_productoxnombre
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_productoxnombre`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_productoxnombre`(in _nombre varchar(255))
begin 

select 
p.idproducto,
p.idcategoria,
c.nombre as canombre,
p.nombre as prnombre,
eqv.idunidadmedida,
uni.sigla,
round(pre.precio,2) as precio,
if(p.estado=1,'ACTIVO','NO ACTIVO') as estado,
p.norden
from producto p
INNER JOIN categoria c on p.idcategoria=c.idcategoria
INNER JOIN unidadequivalente eqv on p.idproducto=eqv.idproducto
INNER JOIN unidadmedida uni on eqv.idunidadmedida=uni.idunidadmedida
INNER JOIN precio pre on eqv.idunidadequivalente=pre.idunidadequivalente
where eqv.idtipounidad=3 and
eqv.idunidadbase=eqv.idunidadmedida and
pre.idtipoprecio=1 and p.nombre like CONCAT('%',_nombre,'%')
order by p.norden asc;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_seriexidalmacenxidtipocomprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_seriexidalmacenxidtipocomprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_seriexidalmacenxidtipocomprobante`(in _idalmacen int(11),
in _idtipocomprobante int(11))
begin 

select 
s.idserie,
s.idalmacen,
a.nombre as anombre,
s.idtipocomprobante,
tc.sigla as tcsigla,
s.nserie,
s.ncorrelativo,
if(s.estado=1,'ACTIVO','NO ACTIVO') as estado
from serie s
INNER JOIN almacen a on s.idalmacen=a.idalmacen
INNER JOIN tipocomprobante tc on s.idtipocomprobante=tc.idtipocomprobante
where s.idalmacen=_idalmacen and s.idtipocomprobante=_idtipocomprobante;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_seriexidalmacenxidtipocomprobantexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_seriexidalmacenxidtipocomprobantexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_seriexidalmacenxidtipocomprobantexestado`(in _idalmacen int(11),
in _idtipocomprobante int(11))
begin 

select 
s.idserie,
s.idalmacen,
a.nombre as anombre,
s.idtipocomprobante,
tc.sigla as tcsigla,
s.nserie,
s.ncorrelativo,
s.estado
from serie s
INNER JOIN almacen a on s.idalmacen=a.idalmacen
INNER JOIN tipocomprobante tc on s.idtipocomprobante=tc.idtipocomprobante
where s.idalmacen=_idalmacen and s.idtipocomprobante=_idtipocomprobante and s.estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_sucursal
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_sucursal`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_sucursal`()
begin

select 
idsucursal,
idempresa,
razonsocial,
direccion,
sede,
telefono,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from sucursal;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_sucursalxidempresa
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_sucursalxidempresa`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_sucursalxidempresa`(in _idempresa int(11))
begin

select 
idsucursal,
idempresa,
razonsocial,
direccion,
sede,
telefono,
estado
from sucursal
where idempresa=_idempresa and estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_sucursalxrazonsocial
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_sucursalxrazonsocial`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_sucursalxrazonsocial`(in _razonsocial VARCHAR(255))
begin

select 
idsucursal,
idempresa,
razonsocial,
direccion,
sede,
telefono,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from sucursal
where razonsocial like CONCAT('%',_razonsocial,'%');

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipocobroxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipocobroxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipocobroxestado`()
begin

select 
idtipocobro,
nombre,
sigla,
estado
from tipocobro
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipocomprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipocomprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipocomprobante`()
begin

select 
idtipocomprobante,
nombre,
sigla,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from tipocomprobante ;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipocomprobantexestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipocomprobantexestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipocomprobantexestado`()
begin 

select 
idtipocomprobante,
nombre,
sigla,
estado
from tipocomprobante
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipodocumento
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipodocumento`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipodocumento`()
begin

select 
idtipodocumento,
nombre,
sigla,
longitud,
estado
from tipodocumento
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipopagoxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipopagoxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipopagoxestado`()
begin

select 
idtipopago,
nombre,
ndia,
estado
from tipopago
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipoprecioxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipoprecioxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipoprecioxestado`()
begin 

select 
idtipoprecio,
nombre,
estado
from tipoprecio
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipounidadxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipounidadxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipounidadxestado`()
begin 

select 
idtipounidad,
nombre,
estado
from tipounidad
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_tipousuarioxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_tipousuarioxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_tipousuarioxestado`()
begin

select 
idtipousuario,
nombre,
sigla,
estado
from tipousuario
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_unidadequivalentexproducto
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_unidadequivalentexproducto`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_unidadequivalentexproducto`(in _idproducto int(11))
begin 

select 
eqv.idunidadequivalente,
eqv.idproducto,
eqv.idtipounidad,
tu.nombre as tunombre,
eqv.idunidadmedida,
(select sigla from unidadmedida where idunidadmedida=eqv.idunidadmedida) as unisigla,
ROUND(eqv.equivale,2) as equivale,
eqv.idunidadbase,
(select sigla from unidadmedida where idunidadmedida=eqv.idunidadbase) as basesigla,
if(eqv.estado=1,'ACTIVO','NO ACTIVO') as estado
from unidadequivalente eqv
INNER JOIN tipounidad tu on eqv.idtipounidad=tu.idtipounidad
where idproducto=_idproducto and eqv.idtipounidad in (3,2);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_unidadequivalentexproductoxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_unidadequivalentexproductoxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_unidadequivalentexproductoxestado`(in _idproducto int(11))
begin 

select 
eqv.idunidadequivalente,
eqv.idproducto,
eqv.idtipounidad,
tu.nombre as tunombre,
eqv.idunidadmedida,
(select sigla from unidadmedida where idunidadmedida=eqv.idunidadmedida) as unisigla,
eqv.equivale,
eqv.idunidadbase,
(select sigla from unidadmedida where idunidadmedida=eqv.idunidadbase) as basesigla,
eqv.estado
from unidadequivalente eqv
INNER JOIN tipounidad tu on eqv.idtipounidad=tu.idtipounidad
where idproducto=_idproducto and eqv.idtipounidad in (3,2) and eqv.estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_unidadmedida
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_unidadmedida`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_unidadmedida`()
begin 

select 
idunidadmedida,
nombre,
sigla,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from unidadmedida;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_unidadmedidaxestado
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_unidadmedidaxestado`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_unidadmedidaxestado`()
begin 

select 
idunidadmedida,
nombre,
sigla,
estado
from unidadmedida
where estado=1;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_unidadmedidaxnombre
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_unidadmedidaxnombre`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_unidadmedidaxnombre`(in _nombre VARCHAR(255))
begin 

select 
idunidadmedida,
nombre,
sigla,
if(estado=1,'ACTIVO','NO ACTIVO') as estado
from unidadmedida
where nombre like concat('%',_nombre,'%');

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_usuario`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_usuario`()
begin 

select
u.idusuario,
u.idtipousuario,
tu.nombre,
u.nombreyapellido,
u.cuenta,
u.clave,
if(u.estado=0,'NO ACTIVO','ACTIVO') as estado
from usuario u
INNER JOIN tipousuario tu on u.idtipousuario=tu.idtipousuario;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_usuarioalmacen
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_usuarioalmacen`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_usuarioalmacen`()
begin

select 
ua.idusuarioalmacen,
ua.idalmacen,
a.nombre,
ua.idusuario,
u.cuenta,
if(ua.estado=1,'ACTIVO','NO ACTIVO') as estado
from usuarioalmacen ua
INNER JOIN usuario u on ua.idusuario=u.idusuario
INNER JOIN almacen a on ua.idalmacen=a.idalmacen;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_usuarioxcuentaxclave
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_usuarioxcuentaxclave`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_usuarioxcuentaxclave`(in _idalmacen int(11),
in _cuenta VARCHAR(255),
in _clave VARCHAR(255))
begin 

declare _idusuario int(11) default -1;

set _idusuario=(
select 
u.idusuario
from usuario u
INNER JOIN tipousuario tu on u.idtipousuario=tu.idtipousuario
INNER JOIN usuarioalmacen ua on u.idusuario=ua.idusuario
where u.cuenta=_cuenta and u.clave=_clave and ua.idalmacen=_idalmacen and
u.estado=1 and ua.estado=1
);

if(_idusuario>0)then

		select 
		u.idusuario,
		u.idtipousuario,		
		tu.nombre as tunombre,
		u.nombreyapellido,
		u.cuenta,
		u.clave,
		u.estado
		from usuario u
		INNER JOIN tipousuario tu on u.idtipousuario=tu.idtipousuario
		INNER JOIN usuarioalmacen ua on u.idusuario=ua.idusuario
		where u.cuenta=_cuenta and u.clave=_clave and ua.idalmacen=_idalmacen and
		u.estado=1 and ua.estado=1;
		
		call Sp_registrar_acceso(_idusuario);

end if;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_listar_usuarioxnombreyapellido
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_listar_usuarioxnombreyapellido`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_listar_usuarioxnombreyapellido`(in _nombreyapellido VARCHAR(255))
begin 

select
u.idusuario,
u.idtipousuario,
tu.nombre,
u.nombreyapellido,
u.cuenta,
u.clave,
if(u.estado=0,'NO ACTIVO','ACTIVO') as estado
from usuario u
INNER JOIN tipousuario tu on u.idtipousuario=tu.idtipousuario
where u.nombreyapellido like CONCAT('%',_nombreyapellido,'%');


end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registar_producto
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registar_producto`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registar_producto`(in _idcategoria int(11),
in _nombre VARCHAR(255),
in _idunidadmedida int(11),
in _precio decimal(20,4),
in _idusuario int(11), in _norden int(11))
begin 

declare _id int(11) default -1;
declare _iduniequiv int(11) default -1;
declare _idprecio int(11) DEFAULT -1;
insert into producto(
idcategoria,
nombre,
pararendimiento,
estado,
fecharegistro,
norden
)values(
_idcategoria,
_nombre,
0,
1,
NOW(),
_norden
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "PRODUCTO", _id, 1);

/* UNIDAD BASE*/

insert into unidadequivalente(
idproducto,
idtipounidad,
idunidadmedida,
equivale,
idunidadbase,
estado,
fecharegistro
)values(
_id,
1,
_idunidadmedida,
1,
_idunidadmedida,
1,
NOW()
);

set _iduniequiv=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "UNIDADEQUIVALENTE", _iduniequiv, 1);

/* PRECIO BASE*/

insert into precio(
idunidadequivalente,
idtipoprecio,
idmoneda,
precio,
estado,
fecharegistro
)values(
_iduniequiv,
1,
1,
0.00,
1,
NOW()
);

set _idprecio=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "PRECIO", _idprecio, 1);

/* UNIDAD VENTA*/

insert into unidadequivalente(
idproducto,
idtipounidad,
idunidadmedida,
equivale,
idunidadbase,
estado,
fecharegistro
)values(
_id,
3,
_idunidadmedida,
1,
_idunidadmedida,
1,
NOW()
);

set _iduniequiv=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "UNIDADEQUIVALENTE", _iduniequiv, 1);

/* PRECIO VENTA PUBLICO*/

insert into precio(
idunidadequivalente,
idtipoprecio,
idmoneda,
precio,
estado,
fecharegistro
)values(
_iduniequiv,
1,
1,
_precio,
1,
NOW()
);

set _idprecio=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "PRECIO", _idprecio, 1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_acceso
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_acceso`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_acceso`(in _idusuario int(11))
begin 

declare _id int(11) default -1;

insert into acceso(
idusuario,
fecharegistro
)values(
_idusuario,
NOW()
);

set _id=(SELECT LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario,"ACCESO",_id,1);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_almacen
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_almacen`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_almacen`(in _idsucursal int(11),
in _nombre VARCHAR(255),
in _direccion VARCHAR(255),
in _telefono VARCHAR(255),
in _idusuario int(11))
begin

declare _id int(11) default -1;

insert into almacen(
idsucursal,
nombre,
direccion,
telefono,
estado,
fecharegistro
)
VALUES(
_idsucursal,
_nombre,
_direccion,
_telefono,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario,"ALMACEN",_id,1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_auditoria
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_auditoria`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_auditoria`(in _idusuario int(11),
in _tabla VARCHAR(255),
in _idtabla int(11),
in _idoperacion int(11))
begin 

insert into auditoria(
idusuario,
tabla,
idtabla,
idoperacion,
estado,
fecharegistro
)
values(
_idusuario,
_tabla,
_idtabla,
_idoperacion,
1,
NOW()
);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_categoria
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_categoria`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_categoria`(in _nombre VARCHAR(255),
in _idusuario int(11))
begin 

declare _id int(11) default -1;

insert into categoria(
nombre,
estado,
fecharegistro
)VALUES(
_nombre,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "CATEGORIA", _id, 1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_cliente
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_cliente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_cliente`(in _razonsocial VARCHAR(255),
in _idtipodocumento int(11),
in _documento VARCHAR(255),
in _direccion VARCHAR(255),
in _idusuario int(11))
begin 

declare _id int(11) default -1;

insert into cliente(
razonsocial,
idtipodocumento,
documento,
direccion,
estado,
fecharegistro
)values(
_razonsocial,
_idtipodocumento,
_documento,
_direccion,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "CLIENTE", _id, 1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_cobro
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_cobro`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_cobro`(in _iddeuda int(11),
in _fechacobro date,
in _idtipocobro int(11),
in _cuentabancaria VARCHAR(255),
in _noperacion VARCHAR(255),
in _monto decimal(20,4),
in _observacion VARCHAR(255),
in _idusuario int(11))
begin

declare _id int(11) default -1;

insert into cobro(
iddeuda,
fechacobro,
idtipocobro,
idmoneda,
cuentabancaria,
noperacion,
monto,
observacion,
estado,
fecharegistro
)values(
_iddeuda,
_fechacobro,
_idtipocobro,
1,
_cuentabancaria,
_noperacion,
_monto,
_observacion,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "COBRO", _id, 1);

UPDATE deuda set 
montocobrado=montocobrado+_monto,
montoactual=montototal-montocobrado
where iddeuda=_iddeuda;

call Sp_registrar_auditoria(_idusuario, "DEUDA", _iddeuda, 2);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_comprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_comprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_comprobante`(in _idserie int(11),
in _fechaemision date,
in _idcliente int(11),
in _subtotal decimal(20,4),
in _igv decimal(20,4),
in _total decimal(20,4),
in _idusuario int(11), _glosa varchar(254))
begin 

declare _id int(11) default -1;
declare _nuserie varchar(255);
declare _nucorrelativo VARCHAR(255);
declare _nucomprobante VARCHAR(255);
declare _tienedeuda int(11) default -1;
declare _iddeuda int(11) default -1;
declare _idtipocomprobante int(11);

set _idtipocomprobante=(
select idtipocomprobante
from  serie 
where idserie=_idserie 
);

set _nuserie=(
select nserie
from serie
where idserie=_idserie
);

set _nucorrelativo=(
select LPAD(convert(ncorrelativo , char(1000)),8,'0')
from serie
where idserie=_idserie
);

set _nucomprobante=(CONCAT(_nuserie,'-',_nucorrelativo));


insert into comprobante(
idserie,
nserie,
ncorrelativo,
ncomprobante,
fechaemision,
idtipopago,
idcliente,
idmoneda,
subtotal,
igv,
total,
descripcion,
idusuario,
estado,
fecharegistro,
glosa
)
VALUES(
_idserie,
_nuserie,
_nucorrelativo,
_nucomprobante,
_fechaemision,
2,
_idcliente,
1,
_subtotal,
_igv,
_total,
'REGISTRO DE COMPROBANTE',
_idusuario,
1,
NOW(),
_glosa
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "COMPROBANTE", _id, 1);

set _tienedeuda=(
select count(*)
from deuda 
where idcliente=_idcliente and estado=1
);

if(_tienedeuda=0)then

if(_idtipocomprobante=1)then
	call Sp_registrar_deuda(_idcliente,_total,_total,0.00,_total,_idusuario);
else
	call Sp_registrar_deuda(_idcliente,0.00,_total,0.00,_total,_idusuario);
end if;


else

set _iddeuda=(
select iddeuda
from deuda
where idcliente=_idcliente and estado=1
);

if(_idtipocomprobante=1)then

	update deuda set 
	montoinicial=montoinicial+_total,
	montototal=montototal+_total,
	montoactual=montototal-montocobrado
	where iddeuda=_iddeuda;

	call Sp_registrar_auditoria(_idusuario, "DEUDA",_iddeuda , 2);

else

	call Sp_actualizar_deuda(_iddeuda,_total,_idusuario);
	
end if;

end if;

update serie set ncorrelativo=ncorrelativo+1 where idserie=_idserie;

call Sp_registrar_auditoria(_idusuario, "SERIE", _idserie, 1);

select _id;


end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_detallecomprobante
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_detallecomprobante`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_detallecomprobante`(in _idcomprobante int(11),
in _idproducto int(11),
in _idunidadequivalente int(11),
in _nunidad decimal(20,4),
in _pbruto decimal(20,4),
in _ptara decimal(20,4),
in _pneto decimal(20,4),
in _preciounitario decimal(20,4),
in _subtotal decimal(20,4),
in _igv decimal(20,4),
in _total decimal(20,4),
in _idusuario int(11))
begin 

declare _id int(11) default -1;

insert into detallecomprobante(
idcomprobante,
idproducto,
idunidadequivalente,
nunidad,
pbruto,
ptara,
pneto,
preciounitario,
subtotal,
igv,
total,
estado,
fecharegistro
)values(
_idcomprobante,
_idproducto,
_idunidadequivalente,
_nunidad,
_pbruto,
_ptara,
_pneto,
_preciounitario,
_subtotal,
_igv,
_total,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "DETALLECOMPROBANTE", _id, 1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_deuda
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_deuda`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_deuda`(in _idcliente int(11),
in _montoinicial decimal(20,4),
in _montototal decimal(20,4),
in _montocobrado decimal(20,4),
in _montoactual decimal(20,4),
in _idusuario int(11))
begin 

declare _iddeuda int(11) default -1;

insert into deuda(
idcliente,
montoinicial,
montototal,
montocobrado,
montoactual,
estado,
fecharegistro
)values(
_idcliente,
_montoinicial,
_montototal,
_montocobrado,
_montoactual,
1,
NOW()
);

set _iddeuda=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "DEUDA",_iddeuda , 1);

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_empresa
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_empresa`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_empresa`(in _idtipodocumento int(11),
in _razonsocial VARCHAR(255),
in _ruc VARCHAR(255),
in _direccion VARCHAR(255),
in _telefono VARCHAR(255),
in _idusuario int(11))
begin

declare _id int(11) default -1;
declare _rucexiste int(11) default 0;

set _rucexiste=(
select COUNT(*)
from empresa
where ruc=_ruc
);


if(_rucexiste=0)then

	insert into empresa(
		idtipodocumento,
		razonsocial,
		ruc,
		direccion,
		telefono,
		estado,
		fecharegistro		
	)
	values(
		_idtipodocumento,	
		_razonsocial,
		_ruc,
		_direccion,
		_telefono,
		1,
		NOW()
	);

	set _id=(select LAST_INSERT_ID());
	
	call Sp_registrar_auditoria(_idusuario,"EMPRESA",_id,1);
	
else

set _id=-2;

end if;

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_precio
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_precio`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_precio`(in _idunidadequivalente int(11),
in _idtipoprecio int(11),
in _idmoneda int(11),
in _precio decimal(20,4),
in _idusuario int(11))
begin

declare _id int(11) default -1;

insert into precio(
idunidadequivalente,
idtipoprecio,
idmoneda,
precio,
estado,
fecharegistro
)values(
_idunidadequivalente,
_idtipoprecio,
_idmoneda,
_precio,
1,
NOW()
);


set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "PRECIO", _id, 1);

select _id;


end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_serie
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_serie`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_serie`(in _idalmacen int(11),
in _idtipocomprobante int(11),
in _nserie VARCHAR(255),
in _ncorrelativo int(11),
in _idusuario int(11))
begin 

declare _id int(11) default -1;

insert into serie(
idalmacen,
idtipocomprobante,
nserie,
ncorrelativo,
estado,
fecharegistro
)values(
_idalmacen,
_idtipocomprobante,
_nserie,
_ncorrelativo,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "SERIE", _id, 1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_sucursal
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_sucursal`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_sucursal`(in _idempresa int(11),
in _razonsocial VARCHAR(255),
in _direccion VARCHAR(255),
in _sede VARCHAR(255),
in _telefono VARCHAR(255),
in _idusuario int(11))
begin 

declare _id int(11) default -1;

insert into sucursal(
idempresa,
razonsocial,
direccion,
sede,
telefono,
estado,
fecharegistro
)
VALUES(
_idempresa,
_razonsocial,
_direccion,
_sede,
_telefono,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario,"SUCURSAL",_id,1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_unidadequivalente
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_unidadequivalente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_unidadequivalente`(in _idproducto int(11),
in _idtipounidad int(11),
IN _idunidadmedida int(11),
in _equivale DECIMAL(20,4),
in _idunidadbase int(11),
in _idusuario int(11))
begin 

declare _id int(11) default -1;
declare _existeunidad int(11) default -1 ;

set _existeunidad=(
select count(*)
from unidadequivalente
where idproducto=_idproducto and idunidadmedida=_idunidadmedida and idtipounidad=_idtipounidad
);

if(_existeunidad=0)then

insert into unidadequivalente(
idproducto,
idtipounidad,
idunidadmedida,
equivale,
idunidadbase,
estado,
fecharegistro
)values(
_idproducto,
_idtipounidad,
_idunidadmedida,
_equivale,
_idunidadbase,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "UNIDADEQUIVALENTE", _id, 1);

else

set _id=-1;

end if;

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_unidadmedida
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_unidadmedida`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_unidadmedida`(in _nombre VARCHAR(255),
in _sigla VARCHAR(255),
in _idusuario int(11))
begin

declare _id int(11) default -1;

insert into unidadmedida(
nombre,
sigla,
estado,
fecharegistro
)
values(
_nombre,
_sigla,
1,
NOW()
);

set _id=(select LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario, "UNIDADMEDIDA", _id, 1);

select _id;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_usuario`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_usuario`(in _idtipousuario int(11),
in _nombreyapellido VARCHAR(255),
in _cuenta VARCHAR(255),
in _clave VARCHAR(255),
in _idusuario int(11))
begin

declare _id int(11) default -1;
declare _cuentaexiste int(11);

set _cuentaexiste=(
	select count(*)
	from usuario
	where cuenta=_cuenta
);

if(_cuentaexiste=0)then

	insert into usuario(
		idtipousuario,
		nombreyapellido,
		cuenta,
		clave,
		estado,
		fecharegistro
	)
	values(
		_idtipousuario,
		_nombreyapellido,
		_cuenta,
		_clave,
		1,
		NOW()
	);
	
	set _id=(select LAST_INSERT_ID());
	
	call Sp_registrar_auditoria(_idusuario,"USUARIO",_id,1);
	
else	

	set _id=-2;
	
end if;

select _id ;

end
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for Sp_registrar_usuarioalmacen
-- ----------------------------
DROP PROCEDURE IF EXISTS `Sp_registrar_usuarioalmacen`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Sp_registrar_usuarioalmacen`(in _idalmacen int(11),
in _idusuarioenalmacen int(11),
in _idusuario int(11))
begin

declare _id int(11) DEFAULt -1;
declare _existe int(11) default 0;

set _existe=(
select COUNT(*)
from usuarioalmacen
where idusuario=_idusuarioenalmacen and idalmacen=_idalmacen
);

if(_existe=0)then

insert into usuarioalmacen(
idalmacen,
idusuario,
estado,
fecharegistro
)VALUES(
_idalmacen,
_idusuarioenalmacen,
1,
NOW()
);

set _id=(SELECT LAST_INSERT_ID());

call Sp_registrar_auditoria(_idusuario,"USUARIOALMACEN",_id,1);

else

set _id=-1;

end if;

SELECT _id;

end
;;
DELIMITER ;
SET FOREIGN_KEY_CHECKS=1;

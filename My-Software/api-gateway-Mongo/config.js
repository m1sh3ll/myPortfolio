/*============================================
; Title: config.js
; Author: 
; Date: 25 July 2020
; Modified By: Michelle Nesbitt
; Description: Demonstrates APIs
==============================================
*/


var config = {};
config.web = {};
config.web.port = process.env.PORT || '3000';
module.exports = config;
config.web.secret = "topsecret";


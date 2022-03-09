import 'dart:io';

import 'package:dio/adapter.dart';
import 'package:dio/dio.dart';
import 'package:studetn_futter/StudentResponse.dart';
import 'package:studetn_futter/studen_model.dart';
import 'package:studetn_futter/variables.dart';

class DioHelper {
  static Dio? dio;

  static init() {
    dio = Dio(
      BaseOptions(
          baseUrl: 'https://localhost:5001', receiveDataWhenStatusError: true),
    );
  }

  static Future<Response?> add({required Student student}) async {
//
    (dio?.httpClientAdapter as DefaultHttpClientAdapter).onHttpClientCreate =
        (HttpClient dioClient) {
      dioClient.badCertificateCallback =
          ((X509Certificate cert, String host, int port) => true);
      return dioClient;
    };
//

    return await dio?.post('/Student/Add',
        data: {"studentName": student.StudentName}).then((value) {
      studentRsponse = StudentRsponse.fromJson(value.data);
    }).catchError((error) {
      print(error.toString());
    });
  }
}

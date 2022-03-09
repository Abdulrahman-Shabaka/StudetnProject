// To parse this JSON data, do
//
//     final studentRsponse = studentRsponseFromJson(jsonString);

import 'dart:convert';

StudentRsponse studentRsponseFromJson(String str) =>
    StudentRsponse.fromJson(json.decode(str));

String studentRsponseToJson(StudentRsponse data) => json.encode(data.toJson());

class StudentRsponse {
  StudentRsponse({
    this.id,
    this.studentName,
  });

  int? id;
  String? studentName;

  factory StudentRsponse.fromJson(Map<String, dynamic> json) => StudentRsponse(
        id: json["id"],
        studentName: json["studentName"],
      );

  Map<String, dynamic> toJson() => {
        "id": id,
        "studentName": studentName,
      };
}

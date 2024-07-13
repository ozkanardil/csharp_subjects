using StandardResponseModels.Assets.Data;
using StandardResponseModels.Assets.Helper;
using StandardResponseModels.Assets.Models;

Console.WriteLine("Stabdard Response Model Project!");

User userData = new User(); 
List<User> users = userData.ListUsers();

// SuccessRequestDataResult örneği oluştur
var result = new SuccessRequestDataResult<List<User>>(users, "İşlem başarıyla tamamlandı.");

// JSON formatında sonuç göster
Console.WriteLine(HelperJsonSerializer.SerializeResult(result));
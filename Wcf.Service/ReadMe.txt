一 新建“WCF服务库”工程，设置其默认命名空间与其它WCF工程的相同

二 在此工程中添加“WCF 服务”实现类，将其契约接口移至Wcf.Contract工程中

三 让Wcf.Host工程引用此工程，并为其在Wcf.Host工程中写一个.svc文件。
.svc文件名为服务访问路径，文件内容示例：<%@ ServiceHost Service="WCF服务实现类的类名" %>
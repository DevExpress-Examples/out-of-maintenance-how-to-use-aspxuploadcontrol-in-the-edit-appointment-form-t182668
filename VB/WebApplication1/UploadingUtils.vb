Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Web
Imports System.Web.Caching

Imports DevExpress.Web.Internal

Public NotInheritable Class UploadingUtils

    Private Sub New()
    End Sub

    Public Shared Sub RemoveFileWithDelay(ByVal key As String, ByVal fullPath As String, ByVal delay As Integer)
        If HttpUtils.GetCache()(key) Is Nothing Then
            Dim absoluteExpiration As Date = Date.Now.Add(New TimeSpan(0, delay, 0))
            HttpUtils.GetCache().Insert(key, fullPath, Nothing, absoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, New CacheItemRemovedCallback(AddressOf RemovedCallback))
        End If
    End Sub
    Public Shared Sub RemovedCallback(ByVal key As String, ByVal value As Object, ByVal reason As CacheItemRemovedReason)
        If File.Exists(value.ToString()) Then
            File.Delete(value.ToString())
        End If
    End Sub
End Class

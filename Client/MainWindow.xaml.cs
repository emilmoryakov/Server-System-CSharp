using System;
using System.IO;
using System.Net;

namespace FTPImageFetcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string ftpHost = "homeworkftp.infinityfreeapp.com";
            string ftpUsername = "if0_34690448";
            string ftpPassword = "R2A7iKhDXrObX"; 

            string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "DownloadedImages");
            Directory.CreateDirectory(targetDirectory);

            FetchImagesFromFTP(ftpHost, ftpUsername, ftpPassword, targetDirectory);

            Console.WriteLine("Images downloaded successfully.");
        }

        private static void FetchImagesFromFTP(string ftpHost, string username, string password, string targetDirectory)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpHost);
                request.Method = WebRequestMethods.Ftp.ListDirectory; // Get the list of files on the FTP server
                request.Credentials = new NetworkCredential(username, password);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                // Download each image from the FTP server
                                DownloadImageFromFTP(Path.Combine(ftpHost, line), username, password, targetDirectory);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        private static void DownloadImageFromFTP(string imageUrl, string username, string password, string targetDirectory)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(imageUrl);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(username, password);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        string fileName = Path.GetFileName(imageUrl);
                        string filePath = Path.Combine(targetDirectory, fileName);

                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            byte[] buffer = new byte[10240];
                            int bytesRead;
                            while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fileStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while downloading image: " + ex.Message);
            }
        }
    }
}


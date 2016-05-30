namespace GameOfLife
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using GameOfLife.Data;
    public class GameSaving : DbContext
    {
        // Контекст настроен для использования строки подключения "GameSaving" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "GameOfLife.GameSaving" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "GameSaving" 
        // в файле конфигурации приложения.
        public GameSaving()
            : base("name=GameSaving")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Saving> Data { get; set; }
    }
}
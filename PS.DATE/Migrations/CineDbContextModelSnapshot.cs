﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PS.DATE;

namespace PS.DATE.Migrations
{
    [DbContext(typeof(ApplicationDbContext.CineDbContext))]
    partial class CineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PS.DOMAIN.Entities.Funciones", b =>
                {
                    b.Property<int>("FuncionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("FuncionId");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Peliculas", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Poster")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sinospsis")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("PeliculaId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR48OaOQHVg55Y9U7v1VD7Cby9_kgc5pcAGUzCvSptDiccLtzjQ",
                            Sinospsis = "Perseo, hijo de Zeus y una mortal, se embarca en una peligrosa misión para salvar la vida de la princesa Andrómeda.",
                            Titulo = "Furia de titanes",
                            Trailer = "https://www.youtube.com/watch?v=cfk-eagYt9Q"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Poster = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT95Db6V4jzEkaZjnWEV5n0qHu1a2InkUgafj3lWQDRxQIxYvL3",
                            Sinospsis = "Iron Man es la historia del industrial multimillonario y genio inventor Tony Stark (ROBERT DOWNEY JR.). ... ",
                            Titulo = "Iron Man 1",
                            Trailer = "https://www.youtube.com/watch?v=8ugaeA-nMTc"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Poster = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/el-increible-hulk-1554403044.jpg?crop=1xw:0.8888888888888888xh;center,top&resize=1200:*",
                            Sinospsis = "Bruce Banner recorre el mundo en busca de un antídoto para librarse de su alter ego. Además tendrá que hacer frente a Emil, un nuevo enemigo",
                            Titulo = "Hulk",
                            Trailer = "https://www.youtube.com/watch?v=xbqNb2PFKKA"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Poster = "https://m.media-amazon.com/images/I/714arK1ZtCL._AC_SY741_.jpg",
                            Sinospsis = "Una profecía condena al reino de Arandelle a vivir en un invierno eterno. La joven Anna, el temerario montañero Kristoff y el reno Sven deben emprender un viaje épico",
                            Titulo = "Frozen 2",
                            Trailer = "https://www.youtube.com/watch?v=QTvcYow0Z5U"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Poster = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQzsbrQ-CBlRMcqxEIuxg_ZJYj_da8ze8mqFRPUGG6o-jBh103S",
                            Sinospsis = "Han pasado 22 años desde que el millonario John Hammond clonara el primer dinosaurio. Con tecnologías mejoradas y nuevas medidas de seguridad",
                            Titulo = "Jurassic World",
                            Trailer = "https://www.youtube.com/watch?v=QTvcYow0Z5U"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Poster = "https://es.web.img3.acsta.net/pictures/19/07/09/11/22/4517830.jpg",
                            Sinospsis = "Tras la muerte de su padre, Simba deberá enfrentarse a su tío para recuperar el trono de Rey de la Selva. Timón y Pumba le acompañarán en su misión.",
                            Titulo = "El rey leon",
                            Trailer = "https://www.youtube.com/watch?v=mb79ctR-E-c"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSOV0JVW82VnxHBgHu1syHyD_cTSYAgLr76gw9ejI4cmySydjmw",
                            Sinospsis = "Los superhéroes se alían para vencer al poderoso Thanos, el peor enemigo al que se han enfrentado. Si Thanos logra reunir las seis gemas del infinito",
                            Titulo = "Vengadores: Infinity War",
                            Trailer = "https://youtu.be/-f5PwE_Q8Fs"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Poster = "https://www.ecartelera.com/carteles/2400/2425/002_m.jpg",
                            Sinospsis = "Jack es un joven artista que gana un pasaje para viajar a América en el Titanic, el transatlántico más grande y seguro jamás construido. ",
                            Titulo = "Titanic",
                            Trailer = "https://www.youtube.com/watch?v=FiRVcExwBVA"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Poster = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.abc.es%2Fplay%2Fpelicula%2Fvengadores-endgame-52759%2F&psig=AOvVaw1Vp2ZWkD-Ska57oIuICNOu&ust=1631149888507000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCKDPyP-Y7vICFQAAAAAdAAAAABAD",
                            Sinospsis = "Después de los eventos devastadores de infiniti wards, el universo está en ruinas debido a las acciones de Thanos, el Titán Loco. ",
                            Titulo = "Vengadores End Game",
                            Trailer = "https://www.youtube.com/watch?v=UQ3bqYKnyhM"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Poster = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.filmaffinity.com%2Fes%2Ffilm495280.html&psig=AOvVaw1GChqFQ6_sWprcqFmAwDSH&ust=1631150036425000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCKD1jcaZ7vICFQAAAAAdAAAAABAD",
                            Sinospsis = "En un exuberante planeta llamado Pandora viven los Na'vi, seres que aparentan ser primitivos pero que en realidad son muy evolucionados.",
                            Titulo = "Avatar",
                            Trailer = "https://www.youtube.com/watch?v=g5deg0HgCmY"
                        });
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Salas", b =>
                {
                    b.Property<int>("SalasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.HasKey("SalasId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            SalasId = 1,
                            Capacidad = 5
                        },
                        new
                        {
                            SalasId = 2,
                            Capacidad = 15
                        },
                        new
                        {
                            SalasId = 3,
                            Capacidad = 30
                        });
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Tickets", b =>
                {
                    b.Property<Guid>("TiketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TiketId", "FuncionId");

                    b.HasIndex("FuncionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Funciones", b =>
                {
                    b.HasOne("PS.DOMAIN.Entities.Peliculas", "Peliculas")
                        .WithMany("Funciones")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PS.DOMAIN.Entities.Salas", "Salas")
                        .WithMany("Funciones")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peliculas");

                    b.Navigation("Salas");
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Tickets", b =>
                {
                    b.HasOne("PS.DOMAIN.Entities.Funciones", "Funciones")
                        .WithMany("Tickets")
                        .HasForeignKey("FuncionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Funciones", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Peliculas", b =>
                {
                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("PS.DOMAIN.Entities.Salas", b =>
                {
                    b.Navigation("Funciones");
                });
#pragma warning restore 612, 618
        }
    }
}

create database pacificprint;

create schema shop;

create table shop.clients (
                              id           serial primary key,
                              firstName    varchar(255) not null,
                              optionalName varchar(255),
                              middleName   varchar(255),
                              lastName     varchar(255),
                              phoneNumber  varchar(255) not null,
                              street       varchar(255) not null,
                              houseNumber  numeric      not null,
                              neighborhood varchar(255) not null,
                              postalCode   numeric      not null,
                              city         varchar(255) not null,
                              state        varchar(255) not null,
                              country      varchar(255) not null,
                              created_at timestamp not null default now(),
                              updated_at timestamp not null default now()
);
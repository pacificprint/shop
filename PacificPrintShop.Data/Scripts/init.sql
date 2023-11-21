create table main.clients
(
    id           integer TEXT not null,
    firstName    TEXT         not null,
    optionalName TEXT,
    middleName   text,
    lastName     text,
    phoneNumber  integer      not null,
    street       text         not null,
    houseNumber  integer      not null,
    neighborhood text         not null,
    postalCode   integer      not null,
    city         text         not null,
    state        text         not null,
    country      text         not null
);

